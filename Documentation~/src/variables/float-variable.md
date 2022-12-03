# FloatVariable

Derives from [`RuntimeVariable<T>`](runtime-variable.md).

## Description

Represents an observable `float` value that can be shared and modified throughout the application.

## Public Methods

- `Add(int)` - Adds a signed `int` value to the variable.
- `Add(float)` - Adds a `float` value to the variable.
- `Subtract(int)` - Subtracts a signed `int` value from the variable.
- `Subtract(float)` - Subtracts a `float` value from the variable.
- `MultiplyBy(int)` - Multiplies the variable by a signed `int` value.
- `MultiplyBy(float)` - Multiplies the variable by a `float` value.
- `DivideBy(int)` - Divides the variable by a signed `int` value.
- `DivideBy(float)` - Divides the variable by a `float` value.
- `CopyFrom(IntVariable)` - Copies the value of another [`IntVariable`](int-variable.md) into this variable.
- `CopyFrom(FloatVariable)` - Copies the value of another [`FloatVariable`](float-variable.md) into this variable.
- `CopyTo(FloatVariable)` - Copies the value from this variable into another [`FloatVariable`](float-variable.md).
- `CopyTo(DoubleVariable)` - Copies the value from this variable into another [`DoubleVariable`](double-variable.md).
- `SetValue(int)` - Sets the value of this variable to a signed `int` value.
