using System;
using System.Linq;

namespace DataManagement
{
    public class ClassDataRegistryReader : IRegistryValueReader
    {
        IRegistryBackend _registry;
        
        public event EventHandler OnUpdated;
        
        public ClassDataRegistryReader(IRegistryBackend registry)
        {
            if(registry == null)
                throw new ArgumentNullException("No registry implimentation provided to " + this.GetType().Name);                
            
            _registry = registry;
            _registry.OnUpdated += DataInRegistryUpdated;
        }
        
        void DataInRegistryUpdated(object caller, EventArgs args)
        {
            OnUpdated?.Invoke(this, EventArgs.Empty);
        }
                
        public string GetStoredValue(Type classType, string fieldName)
        {
            if(!_registry.CurrentConfigurablesData.Contains(classType.FullName))
                throw new NullReferenceException("No registered configurables found for class " + classType.FullName);
            var fields = _registry.CurrentConfigurablesData[classType.FullName].First();
            var field = fields.FirstOrDefault(x => x.Name == fieldName);
            if(field == null)
                throw new NullReferenceException("No field found for class in regisrty. Class name: " + classType.FullName + "Field: "  + fieldName);
            return field.Value;
        }
        
        public void UpdateInstanceWithStoredValues(IConfigurable instance)
        {
            _registry.UpdateInstanceWithStoredValues(instance);
        }
    }
}