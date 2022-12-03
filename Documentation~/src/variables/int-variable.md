# IntVariable

Derives from [`RuntimeVariable<T>`](runtime-variable.md).

## Description

Represents an observable signed `int` value that can be shared and modified throughout the application.

## Public Methods

- `Add(int)` - Adds a signed `int` value to the variable.
- `Subtract(int)` - Subtracts a signed `int` value from the variable.
- `MultiplyBy(int)` - Multiplies the variable by a signed `int` value.
- `DivideBy(int)` - Divides the variable by a signed `int` value.
- `CopyFrom(IntVariable)` - Copies the value of another [`IntVariable`](int-variable.md) into this variable.
- `CopyTo(IntVariable)` - Copies the value from this variable into another [`IntVariable`](int-variable.md).
- `CopyTo(FloatVariable)` - Copies the value from this variable into another [`FloatVariable`](float-variable.md).
- `CopyTo(DoubleVariable)` - Copies the value from this variable into another [`DoubleVariable`](double-variable.md).
