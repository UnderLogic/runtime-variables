# RuntimeVariableWatcher\<T, TVar>

Abstract base class that all other runtime variable watchers derive from.

## Description

Component that watches a [`RuntimeVariable<T>`](../variables/runtime-variable.md) for value changes and raises events.

## Serialized Fields (Inspector)

- `variable : TVar` - The variable to watch for value changes.
- `raiseOnAwake : bool` - Whether the `onValueChanged` event should be raised when `Awake()` is called.
- `raiseOnEnable : bool` - Whether the `onValueChanged` event should be raised when `OnEnable()` is called.
- `raiseOnStart : bool` - Whether the `onValueChanged` event should be raised when `Start()` is called.
- `onValueChanging: UnityEvent<T>` - The actions to perform when the variable value is changing.
- `onValueChanged : UnityEvent<T>` - The actions to perform when the variable value has changed.

## Public Properties

- `Variable : TVar` **(get)** - The variable being watched for value changes.

## Public Methods

- `RaiseValueChanging(T)` - Manually raises the `onValueChanging` event with the value provided.
- `RaiseValueChanged()` - Manually raises the `onValueChanged` event with the current value of the variable.

**NOTE:** Manually raising these events will only trigger the `UnityEvent` actions on **this** component.
