# TransformVariable

Derives from [`RuntimeVariable<T>`](runtime-variable.md).

## Description

Represents an observable `Transform` value that can be shared and modified throughout the application.

## Public Methods

- `SetPosition(Vector3)` - Sets the position of the `Transform` to a new `Vector3` value.
- `SetActive(bool)` - Sets the active state of `GameObject` of the `Transform`.
- `CopyFrom(TransformVariable)` - Copies the value of another [`TransformVariable`](transform-variable.md) into this variable.
- `CopyTo(TransformVariable)` - Copies the value from this variable into another [`TransformVariable`](transform-variable.md).