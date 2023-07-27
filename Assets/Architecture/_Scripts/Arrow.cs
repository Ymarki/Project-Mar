using UnityEngine;

public class Arrow : MonoBehaviour
{

    [SerializeField] private int _damage;

    [SerializeField] private float _speedArrow;

    [SerializeField] private GameObject _player;

    private Rigidbody2D _rigidbody2D;


    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(transform.up * _speedArrow, ForceMode2D.Impulse);
        Destroy(gameObject, 5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Object") Destroy(gameObject);
    }
    public int Damage()
    {
        return _damage;
    }
}
