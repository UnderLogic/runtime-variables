# RuntimeVariable\<T>

Abstract base class that all other runtime variables derive from.

## Description

Represents an observable value `T` that can be shared and modified throughout the application.

## Serialized Fields (Inspector)

- `isReadOnly : bool` - Whether the variable can be mutated.
- `initialValue : T` - Initial value of the variable, will be re-applied on restart.
- `value : T` - The current value of the variable.

## Public Properties

- `IsReadOnly : bool` **(get)** - Whether the variable can be mutated.
- `InitialValue : T` **(get)** - Initial value of the variable, will be re-applied on restart.
- `Value : T` **(get, set)** - The current value of the variable.

## Public Events

- `ValueChanging : UnityAction<T>` - Raised when the value is about to change, providing the new value to be set.
- `ValueChanged : UnityAction<T>` - Raised when the value has changed, providing the newly set value.

**NOTE:** These events are only raised when the new value is **not equal** to the existing value.

## Public Methods

- `GetValue() : T` - Returns the current value of the variable.
- `SetValue(T)` - Sets the value of the variable.
- `SetInitial()` - Sets the value of the variable to the initial value.
- `SetDefault()` - Sets the value of the variable to the `default(T)` value.
- `MakeReadOnly()` - Marks the variable as readonly, useful for freezing after initialization.
- `RaiseValueChanging(T)` - Manually raises a `ValueChanging` event with the value provided.
- `RaiseValueChanged()` - Manually raises a `ValueChanged` event with the current value.

**NOTE:** Trying to modify a readonly set will result in an `InvalidOperationException` being thrown.

## Public Operators

- `operator RuntimeVariable<T> : T` **(implicit)** - Allows the variable to be unwrapped to the native type `T` without needing to explicitly cast it.
