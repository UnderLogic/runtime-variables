using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Variables.Observables
{
    public class ObservableWatcher : MonoBehaviour
    {
        [SerializeField] private ObservableObject observable;

        [Header("Behavior")]
        [SerializeField] private bool raiseOnAwake;
        [SerializeField] private bool raiseOnEnable;
        [SerializeField] private bool raiseOnStart;
        
        [Space]
        public UnityEvent<ObservableObject, string> onPropertyChanging;

        [Space]
        public UnityEvent<ObservableObject, string> onPropertyChanged;

        public ObservableObject Observable => observable;
        
        public void RaisePropertyChanging(string propertyName) => OnPropertyChanging(propertyName);
        public void RaisePropertyChanged(string propertyName) => OnPropertyChanged(propertyName);

        private void Awake()
        {
            if (raiseOnAwake)
                RaisePropertyChanged(null);
        }

        private void Start()
        {
            if (raiseOnStart)
                RaisePropertyChanged(null);
        }

        private void OnEnable()
        {
            if (observable == null)
                return;

            observable.PropertyChanging += OnPropertyChanging;
            observable.PropertyChanged += OnPropertyChanged;

            if (raiseOnEnable)
                RaisePropertyChanged(null);
        }

        private void OnDisable()
        {
            if (observable == null)
                return;
            
            observable.PropertyChanging -= OnPropertyChanging;
            observable.PropertyChanged -= OnPropertyChanged;
        }

        private void OnPropertyChanging(string propertyName) => onPropertyChanging?.Invoke(observable, propertyName);
        private void OnPropertyChanged(string propertyName) => onPropertyChanged?.Invoke(observable, propertyName);
    }
}
