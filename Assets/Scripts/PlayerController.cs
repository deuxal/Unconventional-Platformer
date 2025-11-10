using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float speed;
    public float targetSpeed;
    [Range(0,1)]public float lerpValue = 0.5f;

    [Header("Jump & Gravity")]
    [SerializeField] float jumpForce = 5f;
    [SerializeField] float normalGravity;
    [SerializeField] float fallGravity;
    [SerializeField] float maxVerticalAcceleration = 15f;

    [Header("References")]
    [SerializeField] Rigidbody2D body;
    public Rigidbody2D Body { get { return body; } private set { } }
    [SerializeField] Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetSpeed = speed * moveInput.x;

        Body.linearVelocityY = Mathf.Clamp(Body.linearVelocityY, -maxVerticalAcceleration, maxVerticalAcceleration);
    }

    private void FixedUpdate()
    {
        Body.linearVelocityX = Mathf.Lerp(Body.linearVelocityX,targetSpeed, lerpValue);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Body.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }
}
