using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Color Variable")]
    public class ColorVariable : RuntimeVariable<Color>
    {
        public void CopyFrom(ColorVariable other) => Value = other.Value;
        public void CopyTo(ColorVariable other) => other.Value = Value;
    }
}
