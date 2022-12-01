using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Float Variable")]
    public class FloatVariable : RuntimeVariable<float>
    {
        public void Add(int amount) => Value += amount;
        public void Add(float amount) => Value += amount;

        public void Subtract(int amount) => Value -= amount;
        public void Subtract(float amount) => Value -= amount;

        public void MultiplyBy(int amount) => Value *= amount;
        public void MultiplyBy(float amount) => Value *= amount;

        public void DivideBy(int amount) => Value /= amount;
        public void DivideBy(float amount) => Value /= amount;

        public void CopyFrom(IntVariable other) => Value = other.Value;
        public void CopyFrom(FloatVariable other) => Value = other.Value;
        public void CopyTo(FloatVariable other) => other.Value = Value;
        public void CopyTo(DoubleVariable other) => other.Value = Value;
        
        public void SetValue(int value) => Value = value;
    }
}