// GENERATED AUTOMATICALLY FROM 'Assets/Prefabs/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Debug"",
            ""id"": ""3e3929c6-85c3-445a-b5e8-97b992f7970c"",
            ""actions"": [
                {
                    ""name"": ""StartGame"",
                    ""type"": ""Button"",
                    ""id"": ""d6bbe472-c291-4f29-b08d-1e1e4b915e9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""GenerateNewTarget"",
                    ""type"": ""Button"",
                    ""id"": ""28396063-f112-4fdc-9553-f6553091d2ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""GenerateTrackForFirstTarget"",
                    ""type"": ""Button"",
                    ""id"": ""a7594f6f-8b00-4c85-9e66-1c76fc83f9f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d5cea6d3-1e22-4846-a5f1-e741e37779df"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3974af06-b741-4cb7-b3c3-20f7d9a6fa19"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GenerateNewTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edb47982-1f8e-4fe7-b2ad-e0370e8a969f"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GenerateTrackForFirstTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement"",
            ""id"": ""0244154c-d07c-480d-8a14-3351962b1372"",
            ""actions"": [
                {
                    ""name"": ""X_axis"",
                    ""type"": ""Value"",
                    ""id"": ""24b7b2ca-9e2b-46a9-81df-2b27a32e9363"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""AxisDeadzone"",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Y_axis"",
                    ""type"": ""Value"",
                    ""id"": ""fafa626b-1e01-440f-a0ee-7df247c30e59"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""AxisDeadzone"",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8702fb8b-fe38-4754-ab47-227ce650a0d9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X_axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""58142e78-05ab-437d-9be6-a5c1878add35"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X_axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fb5c0df6-b9e2-4d82-9c13-dfcdd207e192"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X_axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0f8c542c-8577-4d2c-a5ca-43a68f4c1f92"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y_axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""49dcaed6-916f-4185-bfb0-d6e665e83463"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y_axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9844b0f5-f523-4630-8d91-529a9db74bd7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y_axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_StartGame = m_Debug.FindAction("StartGame", throwIfNotFound: true);
        m_Debug_GenerateNewTarget = m_Debug.FindAction("GenerateNewTarget", throwIfNotFound: true);
        m_Debug_GenerateTrackForFirstTarget = m_Debug.FindAction("GenerateTrackForFirstTarget", throwIfNotFound: true);
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_X_axis = m_Movement.FindAction("X_axis", throwIfNotFound: true);
        m_Movement_Y_axis = m_Movement.FindAction("Y_axis", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_StartGame;
    private readonly InputAction m_Debug_GenerateNewTarget;
    private readonly InputAction m_Debug_GenerateTrackForFirstTarget;
    public struct DebugActions
    {
        private @Controls m_Wrapper;
        public DebugActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StartGame => m_Wrapper.m_Debug_StartGame;
        public InputAction @GenerateNewTarget => m_Wrapper.m_Debug_GenerateNewTarget;
        public InputAction @GenerateTrackForFirstTarget => m_Wrapper.m_Debug_GenerateTrackForFirstTarget;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @StartGame.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnStartGame;
                @StartGame.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnStartGame;
                @StartGame.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnStartGame;
                @GenerateNewTarget.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnGenerateNewTarget;
                @GenerateNewTarget.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnGenerateNewTarget;
                @GenerateNewTarget.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnGenerateNewTarget;
                @GenerateTrackForFirstTarget.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnGenerateTrackForFirstTarget;
                @GenerateTrackForFirstTarget.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnGenerateTrackForFirstTarget;
                @GenerateTrackForFirstTarget.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnGenerateTrackForFirstTarget;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StartGame.started += instance.OnStartGame;
                @StartGame.performed += instance.OnStartGame;
                @StartGame.canceled += instance.OnStartGame;
                @GenerateNewTarget.started += instance.OnGenerateNewTarget;
                @GenerateNewTarget.performed += instance.OnGenerateNewTarget;
                @GenerateNewTarget.canceled += instance.OnGenerateNewTarget;
                @GenerateTrackForFirstTarget.started += instance.OnGenerateTrackForFirstTarget;
                @GenerateTrackForFirstTarget.performed += instance.OnGenerateTrackForFirstTarget;
                @GenerateTrackForFirstTarget.canceled += instance.OnGenerateTrackForFirstTarget;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_X_axis;
    private readonly InputAction m_Movement_Y_axis;
    public struct MovementActions
    {
        private @Controls m_Wrapper;
        public MovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @X_axis => m_Wrapper.m_Movement_X_axis;
        public InputAction @Y_axis => m_Wrapper.m_Movement_Y_axis;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @X_axis.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnX_axis;
                @X_axis.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnX_axis;
                @X_axis.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnX_axis;
                @Y_axis.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnY_axis;
                @Y_axis.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnY_axis;
                @Y_axis.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnY_axis;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @X_axis.started += instance.OnX_axis;
                @X_axis.performed += instance.OnX_axis;
                @X_axis.canceled += instance.OnX_axis;
                @Y_axis.started += instance.OnY_axis;
                @Y_axis.performed += instance.OnY_axis;
                @Y_axis.canceled += instance.OnY_axis;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IDebugActions
    {
        void OnStartGame(InputAction.CallbackContext context);
        void OnGenerateNewTarget(InputAction.CallbackContext context);
        void OnGenerateTrackForFirstTarget(InputAction.CallbackContext context);
    }
    public interface IMovementActions
    {
        void OnX_axis(InputAction.CallbackContext context);
        void OnY_axis(InputAction.CallbackContext context);
    }
}
