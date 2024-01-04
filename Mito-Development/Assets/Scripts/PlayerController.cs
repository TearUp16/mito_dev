using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;

    public float collisionOffset = 0.05f;

    public ContactFilter2D movementFilter;

    Animator animator;

    Vector2 movementInput;

    SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    private bool success;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (movementInput != Vector2.zero)
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
            spriteRenderer.flipX = true;
        }
        else if (movementInput.x > 0)
        {
            spriteRenderer.flipX = false;
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

        private void OnMove(InputValue inputValue)
        {
            _movementInput = inputValue.Get<Vector2>();
        }*/
}
