using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Editor
{
    [CustomEditor(typeof(ScriptableObjectVariable), true)]
    public class ScriptableObjectVariableEditor : RuntimeVariableEditor<ScriptableObject> { }
}
