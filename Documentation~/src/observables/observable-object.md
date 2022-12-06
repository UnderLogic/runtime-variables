# ObservableObject

Abstract base class that all other observable objects derive from.

Implements the [`IObservable`](iobservable.md) interface.

## Description

Represents an object that can be observed for property changes.
It can be shared and modified throughout the application.

## Public Events

- `PropertyChanging : UnityAction<string>` - Raised when a property on the object is about to change, providing the property name.
- `PropertyChanged : UnityAction<string>` - Raised when a property on the object has changed, providing the property name.

## Public Methods

- `RaisePropertyChanging(string)` - Manually raises the `PropertyChanging` event with the property name provided.
- `RaisePropertyChanged(string)` - Manually raises the `PropertyChanged` event with the property name provided.

## Protected Methods

- `TrySetProperty<T>(ref T, T, [string]): bool` - Attempts to set the field value with the new `T` value. Optionally, a property name can be provided.

**NOTE:** The `PropertyChanging` and `PropertyChanged` events are only raised when the new value is **not equal** to the existing value.

**NOTE:** The `propertyName` argument is optional and defaults to the value of [`[CallerMemberName]`](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callermembernameattribute?view=net-7.0).

## Example

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
