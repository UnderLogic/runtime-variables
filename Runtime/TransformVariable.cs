using UnityEngine;

namespace UnderLogic.Variables
{
    [CreateAssetMenu(menuName = "Variables/Transform Variable")]
    public class TransformVariable : Variable<Transform>
    {
        public void SetPosition(Vector3 newPosition) => Value.position = newPosition;

        public void SetActive(bool active) => Value.gameObject.SetActive(active);
    }
}