# Watchers

## Overview

Runtime variable watchers are implemented as `MonoBehaviour` components that can be used to bind `UnityEvent` actions to value change events via the Unity Inspector.
This allows the watchers to notify other components without needing to write extra boilerplate code for subscribing and unsubscribing to those events.

It also allows multiple actions to be triggered from a single value change event.
