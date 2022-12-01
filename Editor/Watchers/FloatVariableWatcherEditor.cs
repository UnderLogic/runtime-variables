using UnityEditor;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(FloatVariableWatcher), true)]
    public class FloatVariableWatcherEditor : RuntimeVariableWatcherEditor<float, FloatVariable> { }
}