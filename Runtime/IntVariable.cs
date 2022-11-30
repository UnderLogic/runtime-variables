using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Int Variable")]
    public class IntVariable : RuntimeVariable<int>
    {
        public void Add(int amount) => SetValue(Value + amount);

        public void Subtract(int amount) => SetValue(Value - amount);

        public void MultiplyBy(int amount) => SetValue(Value * amount);

        public void DivideBy(int amount) => SetValue(Value / amount);
    }
}