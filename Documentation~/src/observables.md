# Observables

## Overview

Observable variables are implemented as `ScriptableObject` instances that represent complex data types.
Similar to [`RuntimeVariable<T>`](variables/runtime-variable.md), they can be used to share their data across components and scenes.

They implement the [`IObservable`](observables/iobservable.md) interface which provides `UnityAction` methods when a property changes.
