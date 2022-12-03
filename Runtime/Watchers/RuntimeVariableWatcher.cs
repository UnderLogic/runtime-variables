using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Variables.Watchers
{
    public abstract class RuntimeVariableWatcher<T, TVar> : MonoBehaviour where TVar: RuntimeVariable<T>
    {
        [SerializeField] private TVar variable;

        [Header("Behavior")]
        [SerializeField] private bool raiseOnAwake;
        [SerializeField] private bool raiseOnEnable;
        [SerializeField] private bool raiseOnStart;

        [Space]
        public UnityEvent<T> onValueChanging;
        
        [Space]
        public UnityEvent<T> onValueChanged;

        public TVar Variable => variable;

        public void RaiseValueChanging(T newValue) => onValueChanging?.Invoke(newValue);

        public void RaiseValueChanged()
        {
            if (variable != null)
                onValueChanged?.Invoke(variable.Value);
        }

        private void Awake()
        {
            if (raiseOnAwake)
                RaiseValueChanged();
        }

        private void Start()
        {
            if (raiseOnStart)
                RaiseValueChanged();
        }

        private void OnEnable()
        {
            if (variable == null)
                return;

            variable.ValueChanging += OnVariableValueChanging;
            variable.ValueChanged += OnVariableValueChanged;

            if (raiseOnEnable)
                RaiseValueChanged();
        }

        private void OnDisable()
        {
            if (variable == null)
                return;

            variable.ValueChanging -= OnVariableValueChanging;
            variable.ValueChanged -= OnVariableValueChanged;
        }

        private void OnVariableValueChanging(T newValue) => onValueChanging?.Invoke(newValue);
        private void OnVariableValueChanged(T newValue) => onValueChanged?.Invoke(newValue);
    }
}
