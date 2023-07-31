using UnityEngine;

namespace _Script
{
    public class PlayerModel : MonoBehaviour
    {
        /*
            Основной смысл класса "PlayerModedl" - составить описание объекта "PlayerObject".

            1) Физику движения.
            3) Недопустить выход игрока за пределы экрана по оси X.
        */

        [SerializeField] private GameObject _camera;

        [SerializeField][Range(0, 100)] private float _speed;
        [SerializeField][Range(0f, 100f)] private float _forceJump;

        private bool _isJump = true;

        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            var IGAH = Input.GetAxis("Horizontal");

            if (IGAH != 0)
                _rigidbody2D.velocity = new Vector2(IGAH * _speed, _rigidbody2D.velocity.y);

        }

        private void Update()
        {

            _rigidbody2D.position = new Vector2
                (Mathf.Clamp
                    (_rigidbody2D.position.x,
                    _camera.transform.position.x - 10,
                    _camera.transform.position.x + 10),

                _rigidbody2D.position.y);


            _rigidbody2D.rotation = 0f;

            var IGKCS = Input.GetKeyDown(KeyCode.Space);

            if (IGKCS && _isJump)
            {
                if (IGKCS)
                {
                    _rigidbody2D.AddForce(transform.up * _forceJump, ForceMode2D.Impulse);
                    _isJump = false;
                }
            }

            if (_rigidbody2D.velocity.y <= 0.0001f && _rigidbody2D.velocity.y >= -0.0001f && !_isJump)
            {
                _isJump = true;
            }
        }
    }
}