using UnityEngine;

namespace UnderLogic.Variables.Watchers.Editor
{
    public abstract class RuntimeVariableWatcherEditor<T, TVar> : UnityEditor.Editor where TVar : RuntimeVariable<T>
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
                if (target is RuntimeVariableWatcher<T, TVar> watcher)
                    watcher.RaiseValueChanged();
            }
        }
    }
}