using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Double Variable")]
    public class DoubleVariable : Variable<double>
    {
        public void Add(int amount) => SetValue(Value + amount);
        public void Add(float amount) => SetValue(Value + amount);
        public void Add(double amount) => SetValue(Value + amount);

        public void Subtract(int amount) => SetValue(Value - amount);
        public void Subtract(float amount) => SetValue(Value - amount);
        public void Subtract(double amount) => SetValue(Value - amount);

        public void MultiplyBy(int amount) => SetValue(Value * amount);
        public void MultiplyBy(float amount) => SetValue(Value * amount);
        public void MultiplyBy(double amount) => SetValue(Value * amount);

        public void DivideBy(int amount) => SetValue(Value / amount);
        public void DivideBy(float amount) => SetValue(Value / amount);
        public void DivideBy(double amount) => SetValue(Value / amount);
    }
}