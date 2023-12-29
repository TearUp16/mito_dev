using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed;

    public float destroyDelay = 5f; // Time delay before destroying the bullet

    public int damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke the DestroyBullet function after a delay
        Invoke("DestroyBullet", destroyDelay);
    }

    void DestroyBullet()
    {
        // Destroy the bullet GameObject
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
        //if (collision.gameObject.tag == "Enemy")
        //{
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
        //}
    }
}
