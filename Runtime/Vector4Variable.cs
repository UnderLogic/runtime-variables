using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector4 Variable")]
    public class Vector4Variable : RuntimeVariable<Vector4>
    {
        public void CopyFrom(Vector2IntVariable other) => Value = new Vector4(other.Value.x, other.Value.y);
        public void CopyFrom(Vector2Variable other) => Value = new Vector4(other.Value.x, other.Value.y);
        public void CopyFrom(Vector3Variable other) => Value = new Vector4(other.Value.x, other.Value.y, other.Value.z);
        public void CopyFrom(Vector4Variable other) => Value = other.Value;
        public void CopyTo(Vector4Variable other) => other.Value = Value;
    }
}
