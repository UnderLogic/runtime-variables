using System;
using UnityEngine;

namespace UnderLogic.Variables.References
{
    [Serializable]
    public abstract class RuntimeReference<T, TVar> where TVar: RuntimeVariable<T>
    {
        [SerializeField] private bool useConstant;
        [SerializeField] private T constantValue;
        [SerializeField] private TVar variable;

        public bool UseConstant => useConstant;
        public T ConstantValue => constantValue;
        public TVar Variable => variable;

        public T Value
        {
            get => useConstant ? ConstantValue : Variable.Value;
            set => SetValue(value);
        }

        public T GetValue() => Value;

        public void SetValue(T newValue)
        {
            if (UseConstant)
                return;

            variable.SetValue(newValue);
        }
    }
}