using UnityEngine;

namespace _Script
{
    public class BiterModel : MonoBehaviour
    {
        /*
            Основной смысл класса "BitterModel" - составить описание объекта "Bitter".

            1) Скорость с которой объект Bitter двигается.
            2) Патрулирование между левым и правым чекпоинтами по координатам оси X.

            А так же проверку, разрешается ли объекту Bitter разворачиваться.

            Я установил таймер, который запускается сразу после того, как Bitter развернёться,
            в течении которого, Bitter не можется развернуться снова.
        */

        [SerializeField] private GameObject _checkPointLeft;
        [SerializeField] private GameObject _checkPointRight;

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

            _rigidbody2D.velocity = new Vector2(_speed, _rigidbody2D.velocity.y);

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

            if (_checkPointLeft.transform.position.x > _rigidbody2D.position.x && _turnAround)
            {
                _speed *= -1;
                _turnAround = false;
            }

            if (_checkPointRight.transform.position.x < _rigidbody2D.position.x && _turnAround)
            {
                _speed *= -1;
                _turnAround = false;
            }

        }
    }
}