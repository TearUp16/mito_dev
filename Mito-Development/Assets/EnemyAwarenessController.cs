using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAwarenessController : MonoBehaviour
{
    public bool AwareOfEnemy { get; private set; }

    public Vector2 DirectionToEnemy { get; private set; }

    [SerializeField]
    private float enemyAwarenessDistance;

    private Transform _enemy;

    // Update is called once per frame
    void Update()
    {
        _enemy = FindObjectOfType<Enemy>().transform;

        Vector2 enemyToPlayerVector = _enemy.position - transform.position;
        DirectionToEnemy = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= enemyAwarenessDistance)
        {
            AwareOfEnemy = true;
        }
        else
        {
            AwareOfEnemy = false;
        }
    }
}
