using System.Globalization;
using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/String Variable")]
    public class StringVariable : RuntimeVariable<string>
    {
        public bool IsNullOrEmpty => string.IsNullOrEmpty(Value);
        public bool IsNullOrWhiteSpace => string.IsNullOrWhiteSpace(Value);

        public void CopyFrom(StringVariable other) => Value = other.Value;
        public void CopyTo(StringVariable other) => other.Value = Value;
        
        public void Stringify(bool value) => Value = value.ToString();
        public void Stringify(int value) => Value = value.ToString();
        public void Stringify(float value) => Value = value.ToString(CultureInfo.CurrentCulture);
        public void Stringify(double value) => Value = value.ToString(CultureInfo.CurrentCulture);
    }
}
