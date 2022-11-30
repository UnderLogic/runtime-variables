using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Variables.Samples
{
    public class PlayerNameDisplay : MonoBehaviour
    {
        [SerializeField] private StringVariable playerName;
        [SerializeField] private InputField targetInput;
        
        private void Start()
        {
            if (playerName != null && targetInput != null)
                targetInput.text = playerName.Value;
        }

        private void OnEnable()
        {
            if (playerName != null)
                playerName.ValueChanged += OnPlayerNameChanged;
        }

        private void OnDisable()
        {
            if (playerName != null)
                playerName.ValueChanged -= OnPlayerNameChanged;
        }

        private void OnPlayerNameChanged(string newName)
        {
            Debug.Log($"Player name changed: {newName}", playerName);

            if (targetInput != null)
                targetInput.text = newName;
        }
    }
}