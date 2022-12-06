using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Variables.Observables
{
    public abstract class ObservableObject : ScriptableObject, IObservable
    {
        public event UnityAction<string> PropertyChanging;
        public event UnityAction<string> PropertyChanged;

        public void RaisePropertyChanging(string propertyName) => PropertyChanging.Invoke(propertyName);
        public void RaisePropertyChanged(string propertyName) => PropertyChanged.Invoke(propertyName);
        
        protected bool TrySetProperty<T>(ref T value, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(value, newValue))
                return false;

            RaisePropertyChanging(propertyName);
            value = newValue;
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
