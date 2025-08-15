using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 3.5f;
    [SerializeField] private float jumpForce = 8;

    private float xInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");

        HandleMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    private void HandleMovement()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }
}