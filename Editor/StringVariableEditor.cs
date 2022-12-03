using UnityEditor;

namespace UnderLogic.Variables.Editor
{
    [CustomEditor(typeof(StringVariable), true)]
    public class StringVariableEditor : RuntimeVariableEditor<string> { }
}
