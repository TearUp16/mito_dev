using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Check if the enemy is dead
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        // Perform any death animations or effects
        Destroy(gameObject); // Destroy the enemy GameObject
    }

}
