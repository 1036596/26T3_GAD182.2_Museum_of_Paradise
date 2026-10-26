using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerMovement : MonoBehaviour
{
    private Rigidbody2D physics;
    [SerializeField] private float jumpForce;

    private void Awake()
    {
        physics = GetComponent<Rigidbody2D>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            physics.AddForce(new Vector2(0, jumpForce));
            Debug.Log("Jump" + context.phase);
        }

    }
}
