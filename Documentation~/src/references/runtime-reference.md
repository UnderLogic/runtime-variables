# RuntimeReference\<T, TVar>

Abstract base class that all other runtime references derive from.

Marked with the `Serializable` attribute.

## Description

Represents a value that can point to either a constant value `T` or [`RuntimeVariable<T>`](../variables/runtime-variable.md) value.

Can be toggled at runtime to switch between these values.

## Serialized Fields (Inspector)

- `useConstant : bool` - Whether the reference should point to the constant value or the variable value.
- `constantValue : T` - The constant value to be used, when `useConstant` is `true`.
- `variable: TVar` - The variable value to be used, when `useConstant` is `false`.

## Public Properties

- `UseConstant : bool` - **(get, set)** - Whether the reference should point to the constant value or the variable value.
- `ConstantValue : T` - **(get)** - The constant value to be used, when `UseConstant` is `true`.
- `Variable : TVar` **(get)** - The variable value to be used, when `UseConstant` is `false`.

## Public Methods

- `GetValue() : T` - Returns the current value, either of the constant value or variable value.
- `SetValue(T)` - Sets the value of the variable to a new value. Has no effect when `UseConstant` is `true`.
- `SetUseConstant(bool)` - Sets whether the reference should point to the constant value or the variable value.
