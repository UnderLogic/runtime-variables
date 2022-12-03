# StringVariable

Derives from [`RuntimeVariable<T>`](runtime-variable.md).

## Description

Represents an observable `string` value that can be shared and modified throughout the application.

## Public Properties

- `IsNullOrEmpty : bool` **(get)** - Whether the string is `null` or `""`.
- `IsNullOrWhiteSpace : bool` **(get)** - Whether the string is `null` or whitespace (including empty);

## Public Methods

- `CopyFrom(StringVariable)` - Copies the value of another [`StringVariable`](string-variable.md) into this variable.
- `CopyTo(StringVariable)` - Copies the value from this variable into another [`StringVariable`](string-variable.md).
- `Stringify(bool)` - Sets the value of this variable to the string representation of a `bool` value.
- `Stringify(int)` - Sets the value of this variable to the string representation of a signed `int` value.
- `Stringify(float)` - Sets the value of this variable to the string representation of a `float` value.
- `Stringify(double)` - Sets the value of this variable to the string representation of a `double` value.

**NOTE:** The `Stringify()` methods will format the string using `CultureInfo.CurrentCulture`.