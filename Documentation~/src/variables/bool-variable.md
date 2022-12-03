# BoolVariable

Derives from [`RuntimeVariable<T>`](runtime-variable.md).

## Description

Represents an observable `bool` value that can be shared and modified throughout the application.

## Public Methods

- `Toggle()` - Inverts the boolean value.
- `CopyFrom(BoolVariable)` - Copies the value of another [`BoolVariable`](bool-variable.md) into this variable.
- `CopyTo(BoolVariable)` - Copies the value from this variable into another [`BoolVariable`](bool-variable.md).