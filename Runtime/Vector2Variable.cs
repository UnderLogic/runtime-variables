using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector2 Variable")]
    public class Vector2Variable : RuntimeVariable<Vector2>
    {
        public void CopyFrom(Vector2IntVariable other) => Value = new Vector2(other.Value.x, other.Value.y);
        public void CopyFrom(Vector2Variable other) => Value = other.Value;
        public void CopyTo(Vector2Variable other) => other.Value = Value;
        public void CopyTo(Vector3Variable other) => other.Value = new Vector3(Value.x, Value.y);
        public void CopyTo(Vector4Variable other) => other.Value = new Vector4(Value.x, Value.y);
    }
}
