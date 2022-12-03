# References

## Overview

References are values that can either point to a constant value or a variable, toggleable at runtime.
They are useful when used for quick prototyping and testing of components and features.

Instead of a component needing a constant or hard reference to a [`RuntimeVariable`](variables/runtime-variable.md), a [`RuntimeReference`](references/runtime-reference.md) can be used instead.
This allows developers to start with a constant value initially and swap to a variable value without needing to redesign components.

Their main benefit is that they can be switched at runtime which can greatly speed up play-testing and tweaking.