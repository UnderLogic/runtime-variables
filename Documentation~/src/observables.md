# Observables

## Overview

Observable variables are implemented as `ScriptableObject` instances that represent complex data types.
Similar to [`RuntimeVariable<T>`](variables/runtime-variable.md), they can be used to share their data across components and scenes.

They implement the [`IObservable`](observables/iobservable.md) interface which provides `UnityAction` events when a property changes.

## Usage

Developers are expected to create their own subclasses of [`ObservableObject`](observables/observable-object.md) and provide custom properties.
The `TrySetProperty<T>()` method handles most of the boilerplate code necessary for automatic notifications of property changes.
