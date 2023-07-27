using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float _forceJump;
    private float _jumpSpeed;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
        
    {
        _jumpSpeed = _rigidbody2D.velocity.magnitude;
        if (collision.tag == "Enemy" && _rigidbody2D.velocity.y < 0)
        {
            Destroy(collision.gameObject);
            _rigidbody2D.AddForce(transform.up * _jumpSpeed + transform.up * _forceJump, ForceMode2D.Impulse);
        }
        if(collision.tag == "Biter" && _rigidbody2D.velocity.y < 0)
        {
            Destroy(collision.transform.parent.gameObject);
            _rigidbody2D.AddForce(transform.up * _jumpSpeed + transform.up * _forceJump, ForceMode2D.Impulse);
        }
    }
}
