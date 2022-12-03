using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Int Variable")]
    public class IntVariable : RuntimeVariable<int>
    {
        public void Add(int amount) => Value += amount;
        public void Subtract(int amount) => Value -= amount;
        public void MultiplyBy(int amount) => Value *= amount;
        public void DivideBy(int amount) => Value /= amount;

        public void CopyFrom(IntVariable other) => Value = other.Value;
        public void CopyTo(IntVariable other) => other.Value = Value;
        public void CopyTo(FloatVariable other) => other.Value = Value;
        public void CopyTo(DoubleVariable other) => other.Value = Value;
    }
}
