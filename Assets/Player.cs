using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 3.5f;
    private float xInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
    }
}