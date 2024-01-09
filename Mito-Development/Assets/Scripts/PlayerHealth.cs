using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool isAlive = true;
    private Animator animator;
    EnemySpawner enemySpawner;
    GameOverPrompt gameOverPrompt;
    // Start is called before the first frame update
    public void Start()
    {
        enemySpawner = new EnemySpawner();
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        animator.SetTrigger("hit");
        

        // Check if the player is dead
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Perform any player death-related actions
        animator.SetTrigger("die");
        Destroy(gameObject, 0.5f);
        
        gameOverPrompt = GameObject.FindGameObjectsWithTag("Gameover")[0].GetComponent<GameOverPrompt>();
        gameOverPrompt.OpenGameOverPanel();
        // You might want to add more actions like game over screen, restart, etc.
    }
}
