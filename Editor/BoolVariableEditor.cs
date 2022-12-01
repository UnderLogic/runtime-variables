using UnityEditor;

namespace UnderLogic.Variables.Editor
{
    [CustomEditor(typeof(BoolVariable), true)]
    public class BoolVariableEditor : RuntimeVariableEditor<bool> { }
}