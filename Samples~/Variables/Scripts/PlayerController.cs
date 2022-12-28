using UnityEngine;

namespace UnderLogic.Variables.Samples
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private IntVariable playerGold;
        
        public int CurrentGold
        {
            get => playerGold.Value;
            set => playerGold.Value = value;
        }
    }
}
