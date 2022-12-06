# Custom Types

While this library provides many of the common Unity types you will use, you may want to extend this library with your own custom types specific to your application.
Fortunately, this is rather easy and typically only involves creating a derived class from one of the base classes.
You may also add any additional helper properties and methods as you need.

## Variables

1. Create a new class that derives from [`RuntimeVariable<T>`](variables/runtime-variable.md), where `T` should be the type you wish to wrap.
2. Ensure the new type is marked with the `CreateAssetMenu` attribute, so you can create instances in the Editor.
3. Create any instances of the new variable in your `Assets` folder.
4. Configure the `isReadOnly` and `initialValue` as needed.
5. Now you can use them throughout your application.

**NOTE:** While most people create `ScriptableObject` instances in the Editor, you can create them at runtime as well!

## Observables

1. Create a new class that derives from [`ObservableObject`](observables/observable-object.md).
2. Add `private` backing fields and `public` accessor properties.
3. Use the `TrySetProperty()` method in the property `set` block.
4. Optionally raise events via `RaisePropertyChanged()` method for any computed properties.
5. Ensure the new type is marked with the `CreateAssetMenu` attribute, so you can create instances in the Editor.
6. Create any instances of the new variable in your `Assets` folder.
7. Now you can use them throughout your application.

## References

1. Create a new class that derives from [`RuntimeReference<T, TVar>`](references/runtime-reference.md) where `T` should be the underlying type and `TVar` is the variable type.
2. Ensure the new type is marked with the `Serializable` attribute, so it appears in the Inspector.
3. Now you can use the reference in your components.

### Editor

For the custom Inspector GUI to work you will need to create a new custom property drawer class.
You can reuse the `RuntimeReferencePropertyDrawer` class.

1. Create a new class that derives from `RuntimeReferenceProperyDrawer`.
2. Ensure the new class is marked with the `CustomPropertyDrawer` attribute for your custom reference type.

**NOTE:** You can mark this custom property drawer as the `CustomPropertyDrawer` for multiple reference types.
No need to create multiple variants unless you explicitly need them to behave differently.

## Watchers

1. Create a new class that derives from [`RuntimeVariableWatcher<T, TVar>`](watchers/runtime-variable-watcher.md), where `T` should be the underlying type and `TVar` is the variable type.
2. You can now use the watcher component in your scenes.

### Editor

For the custom Inspector GUI to work you will need to create a new custom editor class.
You can reuse the `RuntimeVariableWatcherEditor<T, TVar>` class.

1. Create a new class that derives from `RuntimeVariableWatcherEditor<T, TVar>`, where `T` should be the underlying type and `TVar` is the variable type.
2. Ensure the new type is marked with the `CustomEditor` attribute for your custom watcher type.

**NOTE:** Unlike the property drawer, a `CustomEditor` can only reference a single type.
You will need to make a custom editor for each custom watcher you make.
