using UnityEditor;

namespace UnderLogic.Variables.Editor
{
    [CustomEditor(typeof(IntVariable), true)]
    public class IntVariableEditor : RuntimeVariableEditor<int> { }
}