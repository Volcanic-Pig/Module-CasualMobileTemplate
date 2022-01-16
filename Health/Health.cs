using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Health : MonoBehaviour
    {
        public Action Killed; 
        
        public int CurrentHealth { get; private set; }
        public float PercentageOfMax => (float)CurrentHealth / maxHealth; 
        
        [SerializeField] private int maxHealth;

        private void Awake()
        {
            CurrentHealth = maxHealth; 
        }

        public void TakeHealth(int amount)
        {
            CurrentHealth = Mathf.Max(0, CurrentHealth - amount);

            if (CurrentHealth == 0)
            {
                Kill();
            }
        }

        public void AddHealth(int amount)
        {
            CurrentHealth = Mathf.Min(maxHealth, CurrentHealth + amount); 
        }

        private void Kill()
        {
            Killed?.Invoke();
            Destroy(gameObject); 
        }
    }
}
