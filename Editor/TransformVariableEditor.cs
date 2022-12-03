using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Editor
{
    [CustomEditor(typeof(TransformVariable), true)]
    public class TransformVariableEditor : RuntimeVariableEditor<Transform> { }
}
