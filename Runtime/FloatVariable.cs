using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Float Variable")]
    public class FloatVariable : Variable<float>
    {
        public void Add(int amount) => SetValue(Value + amount);
        public void Add(float amount) => SetValue(Value + amount);

        public void Subtract(int amount) => SetValue(Value - amount);
        public void Subtract(float amount) => SetValue(Value - amount);

        public void MultiplyBy(int amount) => SetValue(Value * amount);
        public void MultiplyBy(float amount) => SetValue(Value * amount);

        public void DivideBy(int amount) => SetValue(Value / amount);
        public void DivideBy(float amount) => SetValue(Value / amount);
    }
}