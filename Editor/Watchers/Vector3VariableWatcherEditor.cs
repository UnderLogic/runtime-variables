using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(Vector3VariableWatcher), true)]
    public class Vector3VariableWatcherEditor : RuntimeVariableWatcherEditor<Vector3, Vector3Variable> { }
}
