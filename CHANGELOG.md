# Changelog
All notable changes to this library will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

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
