using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Transform Variable")]
    public class TransformVariable : RuntimeVariable<Transform>
    {
        public void SetPosition(Vector3 newPosition) => Value.position = newPosition;
        public void SetActive(bool active) => Value.gameObject.SetActive(active);

        public void CopyFrom(TransformVariable other) => Value = other.Value;
        public void CopyTo(TransformVariable other) => other.Value = Value;
    }
}