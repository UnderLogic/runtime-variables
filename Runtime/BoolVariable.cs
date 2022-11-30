using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Bool Variable")]
    public class BoolVariable : RuntimeVariable<bool>
    {
        public void Toggle() => SetValue(!Value);
    }
}