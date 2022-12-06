# Observables

## Overview

Observable variables are implemented as `ScriptableObject` instances that represent complex data types.
Similar to [`RuntimeVariable<T>`](variables/runtime-variable.md), they can be used to share their data across components and scenes.

They implement the [`IObservable`](observables/iobservable.md) interface which provides `UnityAction` events when a property changes.

## Usage

Developers are expected to create their own subclasses of [`ObservableObject`](observables/observable-object.md) and provide custom properties.
The `TrySetProperty<T>()` method handles most of the boilerplate code necessary for automatic notifications of property changes.

### Example

```csharp
public class PlayerData : ObservableObject
{
    [SerializeField] private string playerName = "Player";
    [SerializeField] private int currentHealth = 50;
    [SerializeField] private int maxHealth = 100;
    
    public string PlayerName
    {
        get => playerName;
        set => TrySetProperty(ref playerName, value);
        // propertyName will be "PlayerName" automatically via CallerMemberName
        // PropertyChanging and PropertyChanged events will be raised
    }
    
    public float HealthPercentage => CurrentHealth * 100f / MaxHealth;
    
    public string CurrentHealth
    {
        get => currentHealth;
        set {
            // If the current health was changed, notify the computed property changed
            if (TrySetProperty(ref currentHealth, value))
                RaisePropertyChanged("HealthPercentage");
        }
    }
    
    public string MaxHealth
    {
        get => maxHealth;
        set {
            // If the max health was changed, notify the computed property changed
            if (TrySetProperty(ref maxHealth, value))
                RaisePropertyChanged("HealthPercentage");
        }
    }
}
```
