using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    private EnemyAwarenessController _enemyAwarenessController;
    private Vector2 _targetDirection;
    [SerializeField]
    private float _rotationSpeed;

    [SerializeField]
    private GameObject gun;

    private void Awake()
    {
        _enemyAwarenessController = GetComponent<EnemyAwarenessController>();
    }

    private void FixedUpdate()
    {
        UpdateEnemyDirection();
        RotateTowardsTarget();
    }
    private void UpdateEnemyDirection()
    {
        if (_enemyAwarenessController.AwareOfEnemy)
        {
            _targetDirection = _enemyAwarenessController.DirectionToEnemy;
        }
        else
        {
            _targetDirection = Vector2.zero;
        }
    }

    private void RotateTowardsTarget()
    {
        if (_targetDirection == Vector2.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation
            (transform.forward, _targetDirection);

        Quaternion rotation = Quaternion.RotateTowards
            (transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);
        gun.transform.rotation = rotation;
    }
}
