using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f;

    private Rigidbody2D _rb;
    private Vector2 _moveVector;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _moveVector.x = Input.GetAxis("Horizontal");
        //_moveVector.y = Input.GetAxis("Vertical");
        _rb.MovePosition(_rb.position + _moveVector * speed * Time.deltaTime);
    }
}
