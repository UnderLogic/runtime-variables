using UnityEditor;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(DoubleVariableWatcher), true)]
    public class DoubleVariableWatcherEditor : RuntimeVariableWatcherEditor<double, DoubleVariable> { }
}