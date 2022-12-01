using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(TransformVariableWatcher), true)]
    public class TransformVariableWatcherEditor : RuntimeVariableWatcherEditor<Transform, TransformVariable> { }
}