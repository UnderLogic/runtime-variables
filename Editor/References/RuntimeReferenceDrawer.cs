using UnityEditor;
using UnityEngine;

namespace UnderLogic.Variables.References.Editor
{
    [CustomPropertyDrawer(typeof(BoolReference), true)]
    [CustomPropertyDrawer(typeof(DoubleReference), true)]
    [CustomPropertyDrawer(typeof(FloatReference), true)]
    [CustomPropertyDrawer(typeof(IntReference), true)]
    [CustomPropertyDrawer(typeof(StringReference), true)]
    [CustomPropertyDrawer(typeof(TransformReference), true)]
    public class RuntimeReferenceDrawer : PropertyDrawer
    {
        private SerializedProperty _useConstant;
        private SerializedProperty _constantValue;
        private SerializedProperty _variable;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            _useConstant = property.FindPropertyRelative("useConstant");
            _constantValue = property.FindPropertyRelative("constantValue");
            _variable = property.FindPropertyRelative("variable");

            var useConstantValue = _useConstant.boolValue;

            var buttonRect = new Rect(position)
            {
                width = 100
            };
            position.xMin = buttonRect.xMax + 4;

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var menu = new GenericMenu();
            menu.AddItem(new GUIContent("Use Constant"), useConstantValue, OnMenuItemSelected, true);
            menu.AddItem(new GUIContent("Use Variable"), !useConstantValue, OnMenuItemSelected, false);

            if (EditorGUI.DropdownButton(buttonRect,
                    new GUIContent(useConstantValue ? "Use Constant" : "Use Variable"), FocusType.Keyboard))
            {
                menu.DropDown(buttonRect);
            }

            EditorGUI.PropertyField(position, useConstantValue ? _constantValue : _variable, GUIContent.none);

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private void OnMenuItemSelected(object value)
        {
            _useConstant.boolValue = (bool)value;
            _useConstant.serializedObject.ApplyModifiedProperties();
        }
    }
}
