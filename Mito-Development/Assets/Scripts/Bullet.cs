using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 10f;

    public float destroyDelay = 5f; // Time delay before destroying the bullet

    public int damage = 40;

    private Vector2 direction;

    private PointManager pointManager;
    [SerializeField] int gainedPoints;
    private ScoreTransition scoreTransition;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke the DestroyBullet function after a delay
        Invoke("DestroyBullet", destroyDelay);

        //Scoring
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        scoreTransition = GameObject.Find("Transition").GetComponent<ScoreTransition>();
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
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
            //scoreTransition.UpdateCurrentScore(5);
            pointManager.UpdateScore(gainedPoints);
            Destroy(gameObject);
        }
        //if (collision.gameObject.tag == "Enemy")
        //{
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
        //}
    }
}
