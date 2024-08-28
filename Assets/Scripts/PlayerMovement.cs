using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f;
    public float jumpAmount = 35;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;

    [SerializeField] private GroundTrigger groundTrigger;

    private Rigidbody2D _rb;
    private Vector2 _moveVector;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _moveVector.x = Input.GetAxis("Horizontal");
        transform.Translate(_moveVector.x * speed * Time.deltaTime, 0, 0);

        if ((Input.GetAxis("Vertical") > 0 || Input.GetKeyDown(KeyCode.Space)) && groundTrigger.IsGrounded)
        {
            _rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }

        if (!groundTrigger.IsGrounded)
        {
            if (_rb.velocity.y >= 0)
            {
                _rb.gravityScale = gravityScale;
            }
            else if (_rb.velocity.y < 0)
            {
                _rb.gravityScale = fallingGravityScale;
            }
        }
    }
}
