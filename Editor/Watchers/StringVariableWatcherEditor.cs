using UnityEditor;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(StringVariableWatcher), true)]
    public class StringVariableWatcherEditor : RuntimeVariableWatcherEditor<string, StringVariable> { }
}