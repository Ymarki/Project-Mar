using UnityEngine;

public class DynamicPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _checkPointUp;
    [SerializeField] private GameObject _checkPointDown;

    [SerializeField][Range(-100, 100)] private float _speed;
    [SerializeField][Range(0, 100)] private float _timerBetweenTurnAround;

    private float _timer;

    private bool _turnAround;

    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _rigidbody2D.velocity = new Vector2(0, _speed);
        if (!_turnAround)
        {
            _timer += Time.deltaTime;
            if (_timer > _timerBetweenTurnAround)
            {
                _turnAround = true;
                _timer = 0;
            }
        }
    }
    private void FixedUpdate()
    {
        if (_checkPointUp.transform.position.y < _rigidbody2D.position.y && _turnAround)
        {
            _speed *= -1;
            _turnAround = false;
        }
        if (_checkPointDown.transform.position.y > _rigidbody2D.position.y && _turnAround)
        {
            _speed *= -1;
            _turnAround = false;
        }
    }
}
