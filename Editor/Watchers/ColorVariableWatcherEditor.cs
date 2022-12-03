using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    [CustomEditor(typeof(ColorVariableWatcher), true)]
    public class ColorVariableWatcherEditor : RuntimeVariableWatcherEditor<Color, ColorVariable> { }
}
