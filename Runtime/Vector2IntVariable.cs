using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector2Int Variable")]
    public class Vector2IntVariable : RuntimeVariable<Vector2Int>
    {
        public void CopyFrom(Vector2IntVariable other) => Value = other.Value;
        public void CopyTo(Vector2IntVariable other) => other.Value = Value;
        public void CopyTo(Vector2Variable other) => other.Value = new Vector2(Value.x, Value.y);
        public void CopyTo(Vector3Variable other) => other.Value = new Vector3(Value.x, Value.y);
        public void CopyTo(Vector4Variable other) => other.Value = new Vector4(Value.x, Value.y);
    }
}
