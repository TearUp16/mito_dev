using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

public class BlackBullet : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;
    public float destroyDelay = 10f; // Time delay before destroying the bullet
    public int damage = 1;

    private void Start()
    {
        Invoke("DestroyBullet", destroyDelay);
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        DestroyBullet();
    }

    void DestroyBullet()
    {
        // Destroy the bullet GameObject
        Destroy(gameObject, destroyDelay);
    }

}
