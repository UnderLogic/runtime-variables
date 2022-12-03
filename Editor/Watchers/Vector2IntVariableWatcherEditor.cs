using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(Vector2IntVariableWatcher), true)]
    public class Vector2IntVariableWatcherEditor : RuntimeVariableWatcherEditor<Vector2Int, Vector2IntVariable> { }
}
