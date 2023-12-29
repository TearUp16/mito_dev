using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamagePlayer : MonoBehaviour
{
    public int damageAmount = 35;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the PlayerHealth component and deal damage
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }
}
