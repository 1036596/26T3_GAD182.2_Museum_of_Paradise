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
    [SerializeField] private Vector2 groundCheckSize;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundLayer;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            playerRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump" + context.phase);
        }

    }

    private bool IsGrounded()
    {
        // Checks for the overlap with anything from the Ground Layer.
        return Physics2D.BoxCast(transform.position, groundCheckSize, 0, -transform.up, groundCheckDistance, groundLayer);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>().x;
    }

    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity = new Vector2(moveInput * speed, playerRigidbody.linearVelocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position -transform.up * groundCheckDistance, groundCheckSize);
    }
}
