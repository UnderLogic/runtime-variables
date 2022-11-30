using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Variables.Samples
{
    public class PlayerScoreDisplay : MonoBehaviour
    {
        [SerializeField] private IntVariable playerScore;
        [SerializeField] private Text targetText;
        
        private void OnEnable()
        {
            if (playerScore != null)
                playerScore.ValueChanged += OnPlayerScoreChanged;
        }

        private void OnDisable()
        {
            if (playerScore != null)
                playerScore.ValueChanged -= OnPlayerScoreChanged;
        }

        private void OnPlayerScoreChanged(int newValue)
        {
            Debug.Log($"Player score changed: {newValue}", playerScore);
            
            if (targetText != null)
                targetText.text = newValue.ToString("n0");
        }
    }
}
