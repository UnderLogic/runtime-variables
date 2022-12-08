using UnderLogic.Variables.Observables;
using UnityEngine;

namespace UnderLogic.Variables.Samples
{
    [CreateAssetMenu(menuName = "Observables/Player Data")]
    public class PlayerData : ObservableObject
    {
        [SerializeField] private string playerName;
        [SerializeField] private int currentHealth;
        [SerializeField] private int maxHealth;
        [SerializeField] private int credits;

        public string PlayerName
        {
            get => playerName;
            set => TrySetProperty(ref playerName, value);
        }

        public int CurrentHealth
        {
            get => currentHealth;
            set => TrySetProperty(ref currentHealth, value);
        }

        public int MaxHealth
        {
            get => maxHealth;
            set => TrySetProperty(ref maxHealth, value);
        }

        public float HealthPercentage => MaxHealth > 0 ? Mathf.Clamp(CurrentHealth * 100f / MaxHealth, 0, 100) : 0;

        public int Credits
        {
            get => credits;
            set => TrySetProperty(ref credits, value);
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0)
                return;

            CurrentHealth = Mathf.Clamp(CurrentHealth - amount, 0, MaxHealth);
        }

        public void Heal(int amount)
        {
            if (amount <= 0)
                return;

            CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0, MaxHealth);
        }

        private void ResetToDefaults()
        {
            PlayerName = "Player";
            MaxHealth = 100;
            CurrentHealth = MaxHealth;
            Credits = 0;
        }

        private void OnEnable() => ResetToDefaults();

        private void OnValidate() => RaisePropertyChanged(null);
    }
}
