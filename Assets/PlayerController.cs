using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        // Get the player's Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // Read keyboard input: A/D or left/right arrows
        float horizontal = Input.GetAxisRaw("Horizontal");

        // Set horizontal speed (X) and zero vertical speed (Y)
        rb.linearVelocity = new Vector2(moveSpeed * horizontal, 0f);
    }
}
