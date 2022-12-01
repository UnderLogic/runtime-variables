using UnityEditor;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(IntVariableWatcher), true)]
    public class IntVariableWatcherEditor : RuntimeVariableWatcherEditor<int, IntVariable> { }
}