using UnityEngine;

namespace UnderLogic.Variables.Samples
{
    public class DebugLogger : MonoBehaviour
    {
        public void LogValue(float value)
        {
            Debug.Log($"Value: {value}", this);
        }
    }
}