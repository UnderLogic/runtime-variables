using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(Vector4VariableWatcher))]
    public class Vector4VariableWatcherEditor : RuntimeVariableWatcherEditor<Vector4, Vector4Variable> { }
}
