using UnityEngine;

public class RangedEnemy : MonoBehaviour
{
    public float speed = 1f;

    SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    private Animator animator;
    private GameObject player;
    Vector2 playerPosition;
    Vector2 direction;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        player = GameObject.FindWithTag("Player");

        if (player == null)
        {
            return;
        } else if (player != null)
        {
            playerPosition = GameObject.FindWithTag("Player").transform.position;
            direction = playerPosition - (Vector2)transform.position;
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
}
