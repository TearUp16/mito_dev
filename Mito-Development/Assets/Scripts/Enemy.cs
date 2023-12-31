using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;

    SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Enemy movement logic
        Vector2 playerPosition = GameObject.FindWithTag("Player").transform.position;
        Vector2 direction = playerPosition - (Vector2)transform.position;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;

        if (direction != Vector2.zero)
        {
            // Player is moving
            animator.SetBool("isMoving", true);
        }
        else
        {
            // Player is idle
            animator.SetBool("isMoving", false);
        }
        if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (direction.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }      
}
