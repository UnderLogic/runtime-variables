using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector3 Variable")]
    public class Vector3Variable : RuntimeVariable<Vector3>
    {
        public void CopyFrom(Vector2IntVariable other) => Value = new Vector3(other.Value.x, other.Value.y);
        public void CopyFrom(Vector2Variable other) => Value = new Vector3(other.Value.x, other.Value.y);
        public void CopyFrom(Vector3Variable other) => Value = other.Value;
        public void CopyTo(Vector3Variable other) => other.Value = Value;
        public void CopyTo(Vector4Variable other) => other.Value = new Vector4(Value.x, Value.y, Value.z);
    }
}
