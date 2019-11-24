using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float movementForce = 5f;
    [SerializeField] private float maxHorizontalVelocity = 5f;
    [SerializeField] private float maxVerticalVelocity = 5f;

    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis( "Horizontal" );
        rigidbody.AddForce(horizontal * movementForce, 0, 0);

        float clampedX = Mathf.Clamp( rigidbody.velocity.x, -maxHorizontalVelocity, maxHorizontalVelocity );                //Min and Max X-axis velocity values.
        float clampedY = Mathf.Clamp( rigidbody.velocity.y, -maxVerticalVelocity, maxVerticalVelocity );                    //Min and Max Y-axis velocity values. (Limited the bounciness).

        rigidbody.velocity = new Vector3( clampedX, rigidbody.velocity.y, rigidbody.velocity.z );
    }
}
