# Changelog
All notable changes to this library will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.6.2] - 2022-12-28

### Added

- `ScriptableObjectVariable` variant
- `ScriptableObjectWatcher` component
- Icons for variables in the Editor
- Icons for watcher components in the Editor

## [0.6.1] - 2022-12-08

### Fixed

- Missing meta files

## [0.6.0] - 2022-12-06

### Added

- `IObservable` interface
- `ObservableObject` class
- `ObservableWatcher` component
- Observables sample scene

## [0.5.0] - 2022-12-03

### Added

- `ColorVariable` variant
- `ColorVariableWatcher` component
- `ColorReference` variant
- `Vector2IntVariable` variant
- `Vector2IntVariableWatcher` component
- `Vector2IntReference` variant
- `Vector2Variable` variant
- `Vector2VariableWatcher` component
- `Vector2Reference` variant
- `Vector3Variable` variant
- `Vector3VariableWatcher` component
- `Vector3Reference` variant
- `Vector4Variable` variant
- `Vector4VariableWatcher` component
- `Vector4Reference` variant
- `SetPosition(Vector3Variable)` method to `TransformVariable` class
- Custom editors for new types

### Changed

- Exposed `Variable` getter property on `RuntimeVariableWatcher` component

## [0.4.2] - 2022-12-03

### Added

- `isReadOnly` and `IsReadOnly` property to `RuntimeVariable` base class
- `MakeReadOnly()` method to `RuntimeVariable` base class

## [0.4.1] - 2022-12-02

### Added

- Docs via `mdbook` in `Documentation~` directory
- GitHub CI/CD workflows for documentation

## [0.4.0] - 2022-11-30

### Added

- `RuntimeVariableEditor<T>` abstract base class
- `BoolVariableEditor` custom editor
- `DoubleVariableEditor` custom editor
- `FloatVariableEditor` custom editor
- `IntVariableEditor` custom editor
- `StringVariableEditor` custom editor
- `TransformVariableEditor` custom editor
- `RuntimeReferenceDrawer` custom property drawer
- `RuntimeVariableWatcherEditor<T, TVar>` abstract base class
- `BoolVariableWatcherEditor` custom editor
- `DoubleVariableWatcherEditor` custom editor
- `FloatVariableWatcherEditor` custom editor
- `IntVariableWatcherEditor` custom editor
- `StringVariableWatcherEditor` custom editor
- `TransformVariableWatcherEditor` custom editor
- `raiseOnAwake` property to `RuntimeVariableWatcher` base class

## [0.3.0] - 2022-11-30

### Added

- `RuntimeReference<T>` abstract base class
- `BoolReference` variant
- `DoubleReference` variant
- `FloatReference` variant
- `IntReference` variant
- `StringReference` variant
- `TransformReference` variant
- `CopyFrom(BoolVariable)` method to `BoolVariable`
- `CopyFrom(IntVariable)` method to `DoubleVariable`
- `CopyFrom(FloatVariable)` method to `DoubleVariable`
- `CopyFrom(DoubleVariable)` method to `DoubleVariable`
- `CopyFrom(IntVariable)` method to `FloatVariable`
- `CopyFrom(FloatVariable)` method to `FloatVariable`
- `CopyFrom(IntVariable)` method to `IntVariable`
- `CopyFrom(StringVariable)` method to `StringVariable`
- `CopyFrom(TransformVariable)` method to `TransformVariable`
- `CopyTo(BoolVariable)` method to `BoolVariable`
- `CopyTo(DoubleVariable)` method to `DoubleVariable`
- `CopyTo(DoubleVariable)` method to `FloatVariable`
- `CopyTo(FloatVariable)` method to `FloatVariable`
- `CopyTo(IntVariable)` method to `IntVariable`
- `CopyTo(FloatVariable)` method to `IntVariable`
- `CopyTo(DoubleVariable)` method to `IntVariable`
- `CopyTo(StringVariable)` method to `StringVariable`
- `CopyTo(TransformVariable)` method to `TransformVariable`
- `SetValue(int)` method to `DoubleVariable`
- `SetValue(float)` method to `DoubleVariable`
- `SetStringValue(int)` method to `FloatVariable`
- `Stringify(bool)` method to `StringVariable`
- `Stringify(int)` method to `StringVariable`
- `Stringify(float)` method to `StringVariable`
- `Stringify(double)` method to `StringVariable`
- References sample scene

### Fixed

- Watchers sample scene UI elements

## [0.2.1] - 2022-11-30

### Changed

- Renamed package to `runtime-variables`
- Renamed `Variable<T>` to `RuntimeVariable<T>` for consistency
- Renamed `VariableWatcher<T>` to `RuntimeVariableWatcher<T>` for consistency

## [0.2.0] - 2022-11-30

### Added

- `VariableWatcher<T>` abstract base class
- `BoolVariableWatcher` component
- `DoubleVariableWatcher` component
- `FloatVariableWatcher` component
- `IntVariableWatcher` component
- `StringVariableWatcher` component
- `TransformVariableWatcher` component
- Watchers sample scene

## [0.1.0] - 2022-11-29

### Added

- `Variable<T>` abstract base class
- `BoolVariable` variant
- `DoubleVariable` variant
- `FloatVariable` variant
- `IntVariable` variant
- `StringVariable` variant 
- `TransformVariable` variant
- Variables sample scene
