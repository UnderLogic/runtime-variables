using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Variables.Samples
{
    public class PlayerGoldDisplay : MonoBehaviour
    {
        [SerializeField] private IntVariable playerGold;
        [SerializeField] private Text goldText;
        
        private void OnEnable()
        {
            playerGold.ValueChanged += OnPlayerGoldChanged;
            OnPlayerGoldChanged(playerGold.Value);
        }

        private void OnDisable()
        {
            playerGold.ValueChanged -= OnPlayerGoldChanged;
        }

        private void OnPlayerGoldChanged(int newValue)
        {
            Debug.Log($"PlayerGold changed: {newValue}");
            
            if (goldText == null)
                return;

            goldText.text = $"Gold: {newValue:n0}";
        }
    }
}
