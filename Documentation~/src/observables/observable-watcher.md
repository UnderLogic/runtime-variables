# ObservableWatcher

Base class that all other observable watchers derive from.

## Description

Component that watches an [`ObservableObject`](observable-object.md) for property changes and raises events.

## Serialized Fields (Inspector)

- `observable : ObservableObject` - The object to watch for property changes.
- `raiseOnAwake : bool` - Whether the `onPropertyChanged` event should be raised when `Awake()` is called.
- `raiseOnEnable : bool` - Whether the `onPropertyChanged` event should be raised when `OnEnable()` is called.
- `raiseOnStart : bool` - Whether the `onPropertyChanged` event should be raised when `Start()` is called.

**NOTE:** The `propertyName` will be `null` when the `onPropertyChanged` event is raised from `raiseOnAwake`, `raiseOnEnable`, or `raiseOnStart`.

# Public Events (Inspector)

- `onPropertyChanging : UnityEvent<ObservableObject, string>` - The actions to perform when a property on the object is changing.
- `onPropertyChanged : UnityEvent<ObservableObject, string>` - The actions to perform when a property on the object has changed.

## Public Properties

- `Observable : ObservableObject` **(get)** - The object being watched for property changes.

## Public Methods

- `RaisePropertyChanging(string)` - Manually raises the `onPropertyChanging` event with the property name provided.
- `RaisePropertyChanged(string)` - Manually raises the `onPropertyChanged` event with the property name provided.

**NOTE:** Manually raising these events will only trigger the `UnityEvent` actions on **this** component.
