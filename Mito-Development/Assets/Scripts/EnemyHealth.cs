using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    private Animator animator;

    [SerializeField] GameObject Victory;
    public void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        //animator.SetBool("isAlive", isAlive);
        
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        animator.SetTrigger("hit");

        Debug.Log(currentHealth);

        // Check if the enemy is dead
        if (currentHealth <= 0) 
        {
            
            Die();
        }
    }

    void Die()
    {
        animator.SetTrigger("die");
        // Perform any death animations or effects
        Invoke("End", 1f);
        Destroy(gameObject, 1f); // Destroy the enemy GameObject

    }

    void End(){
        Victory.SetActive(true);

    }
}
