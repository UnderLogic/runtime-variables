using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Variables
{
    public abstract class RuntimeVariable<T> : ScriptableObject
    {
        [SerializeField] private bool isReadOnly;
        [SerializeField] private T initialValue;
        [SerializeField] private T value;

        public event UnityAction<T> ValueChanging; 
        public event UnityAction<T> ValueChanged;

        public bool IsReadOnly => isReadOnly;
        public T InitialValue => initialValue;

        public T Value
        {
            get => value;
            set => SetValue(value);
        }

        public T GetValue() => Value;

        public void SetValue(T newValue)
        {
            if (IsReadOnly)
                throw new InvalidOperationException("Variable is readonly, cannot change value");
            
            if (EqualityComparer<T>.Default.Equals(newValue, value))
                return;

            RaiseValueChanging(newValue);
            value = newValue;
            RaiseValueChanged();
        }

        public void SetInitial() => SetValue(InitialValue);
        public void SetDefault() => SetValue(default);

        public void MakeReadOnly() => isReadOnly = true;

        public void RaiseValueChanging(T newValue) => ValueChanging?.Invoke(newValue);
        public void RaiseValueChanged() => ValueChanged?.Invoke(Value);

        public static implicit operator T(RuntimeVariable<T> variable) => variable.value;

        private void OnEnable() => value = initialValue;
        private void OnValidate() => RaiseValueChanged();
    }
}
