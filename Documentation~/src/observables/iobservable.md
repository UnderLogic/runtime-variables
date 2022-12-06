# IObservable

## Description

Represents an object that can be observed for property changes.

## Public Events

- `PropertyChanging : UnityAction<string>` - Raised when a property on the object is about to change, providing the property name.
- `PropertyChanged : UnityAction<string>` - Raised when a property on the object has changed, providing the property name.

## Public Methods

- `RaisePropertyChanging(string)` - Manually raises the `PropertyChanging` event with the property name provided.
- `RaisePropertyChanged(string)` - Manually raises the `PropertyChanged` event with the property name provided.
