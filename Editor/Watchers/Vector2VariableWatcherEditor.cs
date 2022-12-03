using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(Vector2VariableWatcher), true)]
    public class Vector2VariableWatcherEditor : RuntimeVariableWatcherEditor<Vector2, Vector2Variable> { }
}
