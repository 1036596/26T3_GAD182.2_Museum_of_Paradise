using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    [Header("P h y s i c s")]
    [SerializeField] private Rigidbody2D playerRigidbody;

    [Header("Movement")]
    [SerializeField] private float jumpForce;
    [SerializeField] private int speed;
    [SerializeField] private float moveInput;

    [Header("Ground Check Stuff")] 
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Vector2 groundCheckSize;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            playerRigidbody.AddForce(new Vector2(0, jumpForce));
            Debug.Log("Jump" + context.phase);
        }

    }

    private bool IsGrounded()
    {
        // Checks for the overlap with anything from the Ground Layer.
        return Physics2D.OverlapCapsule(groundCheck.position, groundCheckSize, CapsuleDirection2D.Horizontal, 0, groundLayer);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>().x;
    }

    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity = new Vector2(moveInput * speed, playerRigidbody.linearVelocity.y);
    }
}
