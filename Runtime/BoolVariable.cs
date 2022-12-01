using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Bool Variable")]
    public class BoolVariable : RuntimeVariable<bool>
    {
        public void Toggle() => SetValue(!Value);

        public void CopyFrom(BoolVariable other) => Value = other.Value;
        public void CopyTo(BoolVariable other) => other.Value = Value;
    }
}