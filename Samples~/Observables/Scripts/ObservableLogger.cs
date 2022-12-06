using UnderLogic.Variables.Observables;
using UnityEngine;

namespace UnderLogic.Variables.Samples
{
    public class ObservableLogger : MonoBehaviour
    {
        public void LogPropertyChanging(ObservableObject obj, string propertyName)
        {
            if (propertyName == null)
                return;
            
            // WARNING: Uses Reflection, very slow!
            // Only for illustration, you should avoid doing this in production code.
            var prop = obj.GetType().GetProperty(propertyName);
            if (prop == null)
                return;

            var currentValue = prop.GetValue(obj);
            Debug.Log($"{obj.name}.{propertyName} is changing, current value: {currentValue}", obj);
        }

        public void LogPropertyChanged(ObservableObject obj, string propertyName)
        {
            if (propertyName == null)
                return;
            
            // WARNING: Uses Reflection, very slow!
            // Only for illustration, you should avoid doing this in production code.
            var prop = obj.GetType().GetProperty(propertyName);
            if (prop == null)
                return;

            var newValue = prop.GetValue(obj);
            Debug.Log($"{obj.name}.{propertyName} has changed, new value: {newValue}", obj);
        }
    }
}
