using UnderLogic.Variables.Observables;
using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Variables.Samples
{
    public class PlayerUserInterface : MonoBehaviour
    {
        [Header("Name")]
        [SerializeField] private Text nameText;
        
        [Header("Health")]
        [SerializeField] private Slider healthSlider;
        
        [Header("Buttons")]
        [SerializeField] private Button damageButton;
        [SerializeField] private Button healButton;

        [Header("Credits")]
        [SerializeField] private Text creditsText;
        
        public void OnPlayerDataChanged(ObservableObject obj, string propertyName)
        {
            if (obj is not PlayerData playerData)
                return;

            if (nameText != null)
                nameText.text = $"{playerData.PlayerName}'s Health";

            if (healthSlider != null)
                healthSlider.value = playerData.HealthPercentage;

            if (damageButton != null)
                damageButton.interactable = playerData.CurrentHealth > 0;

            if (healButton != null)
                healButton.interactable = playerData.CurrentHealth < playerData.MaxHealth;

            if (creditsText != null)
                creditsText.text = $"{playerData.Credits:n0} Credit(s)";
        }
    }
}
