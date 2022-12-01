using UnderLogic.Variables.References;
using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Variables.Samples
{
    public class HealthDisplay : MonoBehaviour
    {
        [SerializeField] private Slider healthSlider;
        
        [SerializeField] private FloatReference currentHealth;
        [SerializeField] private FloatReference maxHealth;

        private void Start() => UpdateHealthBar();
        private void Update() => UpdateHealthBar();

        private void UpdateHealthBar()
        {
            if (healthSlider == null)
                return;

            healthSlider.maxValue = maxHealth.Value;
            healthSlider.value = currentHealth.Value;
        }
    }
}
