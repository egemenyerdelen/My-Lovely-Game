using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    
    public Stat damage;
    public Stat armor;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        // Test function
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damageToTake)
    {
        damageToTake -= armor.GetValue();
        damageToTake = Math.Clamp(damageToTake, 0, Int32.MaxValue);
        
        currentHealth -= damageToTake;
        Debug.Log($"{transform.name} takes {damageToTake} damage");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        // Die in some way
        // This method is meant to be overwritten
        Debug.Log($"{transform.name} died.");
    }
}
