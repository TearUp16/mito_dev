using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAwarenessController : MonoBehaviour
{
    public bool AwareOfEnemy { get; private set; }

    public Vector2 DirectionToEnemy { get; private set; }

    [SerializeField]
    private float enemyAwarenessDistance;

    private Transform _enemyFound;
    private GameObject _enemy;

    // Update is called once per frame
    void Update()
    {


        //put the enemy in a game object first
        _enemy = GameObject.FindGameObjectWithTag("Enemy");

        if (_enemy == null)
        {
            return;
        }

        if (_enemy != null)
        {
            _enemyFound = _enemy.transform;
            Vector2 enemyToPlayerVector = _enemyFound.position - transform.position;
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

        /*Vector2 enemyToPlayerVector = _enemy.position - transform.position;
        DirectionToEnemy = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= enemyAwarenessDistance)
        {
            AwareOfEnemy = true;
        }
        else
        {
            AwareOfEnemy = false;
        }
    }*/
}
