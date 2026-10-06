using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        // gets the player's rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // reads the inputs for ad or left and right arrows
        float horizontal = Input.GetAxisRaw("Horizontal");

        // sets horizontal speed to a value and sets vertical speed to 0
        rb.linearVelocity = new Vector2(moveSpeed * horizontal, 0f);
    }
}
