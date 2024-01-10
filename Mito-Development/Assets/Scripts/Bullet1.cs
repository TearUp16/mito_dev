using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float moveSpeed = 10f;

    public float destroyDelay = 5f; // Time delay before destroying the bullet

    public int damage = 40;

    private Vector2 direction;

    private PointManager pointManager;
    PlayerController playerController;
    private ScoreTransition scoreTransition;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke the DestroyBullet function after a delay
        Invoke("DestroyBullet", destroyDelay);

        //Scoring
        scoreTransition = GameObject.Find("Transition").GetComponent<ScoreTransition>();
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
        // Move the bullet in the specified direction
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        //Debug.Log(playerController.movementInput.x);
        //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    public void SetBulletDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }

    private void FixedUpdate()
    {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);

            pointManager.UpdateScore(5);
            //scoreTransition.UpdateCurrentScore(5);
            
            Destroy(gameObject);
        }
        //if (collision.gameObject.tag == "Enemy")
        //{
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
        //}
    }
}
