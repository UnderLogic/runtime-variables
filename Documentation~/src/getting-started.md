# Getting Started

## Context

To best understand the purpose of this library and the problems it solves,
it is highly recommended to watch the [Unite 2017: Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk)
by Ryan Hipple.

## Use Cases

### Shared Data

The common case of needing to share data between various components, potentially across multiple scenes.
Easy to drag and drop references in the Editor and view/modify them in the Inspector during play mode.

See `runtime-collections` library in the [related-libraries](related-libraries.md) section for working with collections.

### Complex Types

The common case of needing to represent a complex data type with various types of fields.
Using the [ObservableObject](observables/observable-object.md) allows property value changes to be seen by other components.

### Singleton

The common case of needing a single, global instance of data that can be accessed everywhere.
This avoids the common pitfalls of traditional Unity singleton objects.

### Event-Based Architecture

The case of only wanting to update or perform actions when necessary (reactively) instead of wastefully computing each frame.
This is very common in UI-heavy applications.

See `event-channels` library in the [related-libraries](related-libraries.md) section for working with an event bus.

### Quick Prototyping

The case of being able to swap between constant and variable values on the fly, allowing rapid prototyping and tweaking.
By using references you can avoid refactoring components or having to restart your application to test each change.

## Samples

The `Samples~` folder contains sample scenes showcasing various aspects of the library in action.
It is recommended to import and play around with them in Unity to get a feel for how to use the library.
