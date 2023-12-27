using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        // Enemy movement logic
        Vector2 playerPosition = GameObject.FindWithTag("Player").transform.position;
        Vector2 direction = playerPosition - (Vector2)transform.position;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
