using UnityEngine.Events;

namespace UnderLogic.Variables.Observables
{
    public interface IObservable
    {
        public event UnityAction<string> PropertyChanging;
        public event UnityAction<string> PropertyChanged;

        public void RaisePropertyChanging(string propertyName);
        public void RaisePropertyChanged(string propertyName);
    }
}
