using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(ScriptableObjectVariableWatcher), true)]
    public class
        ScriptableObjectVariableWatcherEditor : RuntimeVariableWatcherEditor<ScriptableObject,
            ScriptableObjectVariable> { }
}
