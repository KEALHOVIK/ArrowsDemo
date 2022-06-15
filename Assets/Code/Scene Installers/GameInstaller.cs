using AssetScripts.AssetCreation;
using DataAccess.DiskAccess.GameFolders;
using DataAccess.DiskAccess.Serialization;
using DataManagement;
using Game.Gameplay.Meta;
using Game.Gameplay.Meta.Skins;
using Game.Gameplay.Realtime;
using Game.Gameplay.Realtime.GameplayComponents.Projectiles;
using Game.Gameplay.Realtime.OperationSequence;
using Game.Gameplay.Realtime.OperationSequence.Operation;
using Game.Gameplay.Realtime.PlayfieldComponents.Target;
using Game.Gameplay.Realtime.PlayfieldComponents.Track;
using Game.GameState;
using Game.Microinteracions;
using Settings;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{    
    [SerializeField]
    private ArrowsRunthroughFactory _runthroughFactory;
    [SerializeField]
    private ProjectileGenerator _projectileGenerator; 
    [SerializeField]
    private TargetGroupGenerator _targetGenerator; 
    [SerializeField]
    private AppStateFactory _appStateFactory;
    
    public override void InstallBindings()
    {                
        Container.Bind<OperationExecutor>().AsTransient().NonLazy();
        Container.Bind<ISequenceCalculator>().To<RandomSequenceGenerator>().AsSingle();
        Container.Bind<ISequenceManager>().To<SequenceManager>().AsSingle();
        Container.Bind<ISplineTrackProvider>().To<RandomizedSmoothTrackGenerator>().FromNewComponentOnNewGameObject().AsSingle();
        Container.Bind<ITrackPopulator>().To<TrackFiller>().FromNewComponentOnNewGameObject().AsSingle(); 
        Container.Bind<ITargetProvider>().FromInstance(_targetGenerator).AsSingle();  
        Container.Bind<IProjectileProvider>().FromInstance(_projectileGenerator).AsSingle();  
                
        Container.Bind<IDiskSerialization>().To<JsonDataStorage>().AsSingle();
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
            Container.Bind<IStreamingAssetsReader>().To<WinStreamingAssets>().AsSingle();
        else if (Application.platform == RuntimePlatform.Android)
            Container.Bind<IStreamingAssetsReader>().To<AndroidStreamingAssets>().AsSingle();
        Container.Bind<IGameFolders>().To<GameFolders>().AsSingle();
        
        ComposeSkinsImport();
        ComposeUserContextManagement();  
        ComposeSettingsManagement();    
        ComposeSettings();  
        ComposeMicrointeractions();        
                                 
        Container.Bind<RunthroughContextManager>().AsSingle().NonLazy();
        Container.Bind<IRunthroughFactory>().FromInstance(_runthroughFactory).AsSingle();     
        Container.Bind<PreRunFactory>().AsSingle().NonLazy();        
        Container.Bind<RunthroughFactory>().AsSingle().NonLazy();    
        Container.Bind<IAppStateFactory>().FromInstance(_appStateFactory).AsSingle();  
    }
    
    void ComposeSkinsImport()
    {
        // Container.Bind<ProjectileColection>().AsSingle().NonLazy();  
        // Container.Bind<ProjectileRawModelLoader>().AsSingle().NonLazy();    
    }
    
    void ComposeUserContextManagement()
    {
        var gameFolders = new GameFolders();
        var RegistryFactory = new RegistryFactory(gameFolders);
        var nonVolatileStorage = new JsonStorage(new DiskAcessor());
        var _userRegistry = RegistryFactory.CreateRegistry("UserContext", nonVolatileStorage);
        
        var userContextManager = new UserContextManager(_userRegistry.Ingester, _userRegistry.Manager);
        var userContextConverter = new UserContextConverter(_userRegistry.Reader);
        Container.Bind<IContextProvider>().FromInstance(userContextConverter).AsSingle(); 
        Container.Bind<IUpdatedNotification>().WithId("userContextNotifier").FromInstance(userContextManager).AsTransient(); 
        Container.Bind<IRegistryAccessor>().WithId("userRegistryAccessor").FromInstance(_userRegistry.Accessor).AsTransient(); 
        Container.Bind<IRegistryValueReader>().WithId("userRegistryAccessor").FromInstance(_userRegistry.Accessor).AsTransient(); 
    }
    
    void ComposeSettingsManagement()
    {
        var gameFolders = new GameFolders();
        var RegistryFactory = new RegistryFactory(gameFolders);
        var nonVolatileStorage = new JsonStorage(new DiskAcessor());
        var _settingsRegistry = RegistryFactory.CreateRegistry("GameSettings", nonVolatileStorage);
        
        var settingsRegistryManager = new SettingsRegistryManager(_settingsRegistry.Ingester, _settingsRegistry.Manager, _settingsRegistry.Reader);
        Container.Bind<IUpdatedNotification>().WithId("settingsNotifier").FromInstance(settingsRegistryManager).AsTransient(); 
        Container.Bind<IRegistryIngester>().WithId("settingsIngester").FromInstance(_settingsRegistry.Ingester).AsTransient(); 
        Container.Bind<IRegistryAccessor>().WithId("settingsAccessor").FromInstance(_settingsRegistry.Accessor).AsTransient(); 
        Container.Bind<IRegistryValueReader>().WithId("settingsAccessor").FromInstance(_settingsRegistry.Accessor).AsTransient(); 
    }    
     
    void ComposeSettings()
    {
        Container.Bind<ResolutionScaling>().AsSingle().NonLazy();  
        Container.Bind<GraphicsPresset>().AsSingle().NonLazy(); 
    }  
    
    void ComposeMicrointeractions()
    {
        Container.Bind<VibrationService>().AsSingle().NonLazy();
    }
}