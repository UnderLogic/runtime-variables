using UnityEditor;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(BoolVariableWatcher), true)]
    public class BoolVariableWatcherEditor : RuntimeVariableWatcherEditor<bool, BoolVariable> { }
}