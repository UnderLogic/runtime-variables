using UnityEngine;

namespace UnderLogic.Variables.Editor
{
    public abstract class RuntimeVariableEditor<T> : UnityEditor.Editor
    {
        private static readonly GUILayoutOption[] ButtonLayout =
        {
            GUILayout.MinWidth(192),
            GUILayout.MinHeight(28),
        };

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GUILayout.Space(4);
            if (GUILayout.Button("Raise Value Changed", ButtonLayout))
            {
                if (target is RuntimeVariable<T> variable)
                    variable.RaiseValueChanged();
            }
        }
    }
}