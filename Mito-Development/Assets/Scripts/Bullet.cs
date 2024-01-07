using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed;

    public float destroyDelay = 5f; // Time delay before destroying the bullet

    public int damage = 40;

    private PointManager pointManager;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke the DestroyBullet function after a delay
        Invoke("DestroyBullet", destroyDelay);

        //Scoring
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void DestroyBullet()
    {
        // Destroy the bullet GameObject
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerController.movementInput.x);
        //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        
    }

    private void FixedUpdate()
    {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);

            pointManager.UpdateScore(5);
            Destroy(gameObject);
        }
        //if (collision.gameObject.tag == "Enemy")
        //{
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
        //}
    }
}
