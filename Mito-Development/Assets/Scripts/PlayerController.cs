using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;

    /*[SerializeField]
    private float _rotationSpeed; */

    public float collisionOffset = 0.05f;

    public ContactFilter2D movementFilter;

    Animator animator;

    public Vector2 movementInput;
    Vector2 movementVariable;

    SpriteRenderer spriteRenderer;

    Rigidbody2D rb;
    /*private EnemyAwarenessController _enemyAwarenessController;
    private Vector2 _targetDirection;*/

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    private bool success;
    private bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //_enemyAwarenessController = GetComponent<EnemyAwarenessController>();
    }

    public void Update()
    {
        rb.velocity = new Vector2(movementInput.x * moveSpeed, 0);
        rb.velocity = new Vector2(0, movementInput.y * moveSpeed);

        movementVariable.x = movementInput.x;
        movementVariable.y = movementInput.y;
    }

    public void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }

    private void FixedUpdate()
    {

        /*UpdateEnemyDirection();
        RotateTowardsTarget();*/

        rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);

        if (movementInput.x > 0.01f)
        {
            transform.localScale = new Vector3(0.8f, 0.8f, 1);
        } else if (movementInput.x < -0.01f)
        {
            transform.localScale = new Vector3(-0.8f, 0.8f, 1);
            
        }
    }

    /*private void UpdateEnemyDirection()
    {
        if (_enemyAwarenessController.AwareOfEnemy)
        {
            _targetDirection = _enemyAwarenessController.DirectionToEnemy;
        }
        else
        {
            _targetDirection = Vector2.zero;
        }
    }*/

/*    private void RotateTowardsTarget()
    {
        if (_targetDirection == Vector2.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation
            (transform.forward, _targetDirection);

        Quaternion rotation = Quaternion.RotateTowards
            (transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);
            rb.SetRotation(rotation);
    }*/
    /* --------
     * if (movementInput != Vector2.zero)
    {
        bool success = TryMove(movementInput);

        if (!success)
        {
            success = TryMove(new Vector2(movementInput.x, 0));

            if (success)
            {
                success = TryMove(new Vector2(0, movementInput.y));
            }
        }
        animator.SetBool("isMoving", success);
    }
    else
    {
        animator.SetBool("isMoving", false);
    }
    if (movementInput.x < 0)
    {
        Debug.Log(movementInput.x);
        //spriteRenderer.flipX = true;
        transform.Rotate(0, 180, 0);
    }
    else if (movementInput.x > 0)
    {
        Debug.Log(movementInput.x);
        //spriteRenderer.flipX = false;
        transform.Rotate(0, 0, 0);
    }
}

private bool TryMove(Vector2 direction)
{
    int count = rb.Cast(
            direction,
            movementFilter,
            castCollisions,
            moveSpeed * Time.fixedDeltaTime + collisionOffset);

    if (count == 0)
    {
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
        return true;
    }
    else
    {
        return false;
    }
}

void OnMove(InputValue movementValue)
{
    movementInput = movementValue.Get<Vector2>();
}

     -------*/

    /*    [SerializeField]
        private float _speed;

        [SerializeField]
        private float _rotationSpeed;

        private Rigidbody2D _rigidbody2D;
        private Vector2 _movementInput;
        private Vector2 _smoothedMovementInput;
        private Vector2 _movementInputSmoothVelocity;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }*/

    //any changes to the rigidbody is recommended to be made inside this 
    /*    private void FixedUpdate()
        {
            SetPlayerVelocity();
            RotateInDirectionOfInput();
        }

        private void SetPlayerVelocity()
        {
            _smoothedMovementInput = Vector2.SmoothDamp(
                        _smoothedMovementInput,
                        _movementInput,
                        ref _movementInputSmoothVelocity,
                        0.1f);

            _rigidbody2D.velocity = _smoothedMovementInput * _speed;
        }

        private void RotateInDirectionOfInput()
        {
            if (_movementInput != Vector2.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(
                    transform.forward, _smoothedMovementInput);

                Quaternion rotation = Quaternion.RotateTowards(
                    transform.rotation, targetRotation,
                    _rotationSpeed * Time.deltaTime);

                _rigidbody2D.MoveRotation(rotation);
            }
        }

        */
}
