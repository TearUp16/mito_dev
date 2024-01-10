using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemyController : MonoBehaviour
{
    public float attackDistance = 5f;
    public float attackCooldown = 2f;
    public GameObject bulletPrefab;
    public Transform shootPoint;

    private Transform player;
    private float lastAttackTime;
    Vector2 direction;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackDistance && Time.time - lastAttackTime >= attackCooldown)
        {
            // Set the enemy's distance to the player
            direction = (player.position - transform.position).normalized;
            // Optionally, you can add logic to rotate the enemy towards the player
            //transform.up = direction;

            // Shoot a bullet
            Shoot();
        }
    }

    void Shoot()
    {
        lastAttackTime = Time.time;

        // Instantiate the bullet at the shoot point
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        // Optionally, you can set additional properties for the bullet (e.g., speed, damage)
        // Access the BulletController script and set its properties

        // Example:
        /*Bullet bulletController = bullet.GetComponent<Bullet>();
        if (bulletController != null)
        {
            bulletController.SetBulletDirection(direction);
        }*/
    }
}
