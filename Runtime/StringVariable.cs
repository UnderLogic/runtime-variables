using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/String Variable")]
    public class StringVariable : Variable<string>
    {
        public bool IsNullOrEmpty => string.IsNullOrEmpty(Value);
        public bool IsNullOrWhiteSpace => string.IsNullOrWhiteSpace(Value);
    }
}