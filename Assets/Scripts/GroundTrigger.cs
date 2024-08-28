using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class GroundTrigger : MonoBehaviour
{
    private BoxCollider2D _collider;
    private bool _isGrounded;

    public bool IsGrounded { get { return _isGrounded; } }

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
        _isGrounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isGrounded = false;
    }
}
