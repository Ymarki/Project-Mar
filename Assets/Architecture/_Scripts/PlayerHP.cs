using UnityEngine;
using UnityEngine.UI;

namespace _Script
{
    public class PlayerHP : MonoBehaviour
    {
        /*
            Основной смысл класса "PlayerHP" - добавить систему HP для объекта "Player".

            1) Текущее состояние здоровья.
            2) Отслеживание нанесённого урона.
        */

        [SerializeField][Range(0, 10)] private int _countOfHealth;
        [SerializeField][Range(0, 10)] private int _healthPoint;

        private int _damageArrow;
        private int _damageBiter;

        [SerializeField] private float _timerBetweenDamage;
        private float _timer;

        [SerializeField] private Arrow _arrow;
        [SerializeField] private BiterDamage _biterDamage;

        [SerializeField] private Image[] _hearts;

        [SerializeField] private Sprite _fullHeart;
        [SerializeField] private Sprite _emptyHeart;

        private bool _isDamage;


        private void Start()
        {
            _isDamage = true;
            _damageArrow = _arrow.Damage();
            _damageBiter = _biterDamage.Damage();
        }


        private void FixedUpdate()
        {

            if (_countOfHealth < _healthPoint) _healthPoint = _countOfHealth;

            for (int i = 0; i < _hearts.Length; i++)
            {

                if (i < _healthPoint) _hearts[i].sprite = _fullHeart;

                else _hearts[i].sprite = _emptyHeart;


                if (i < _countOfHealth) _hearts[i].enabled = true;

                else _hearts[i].enabled = false;

            }
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.gameObject.tag == "Arrow" && _isDamage)
            {
                _isDamage = false;
                Destroy(collision.gameObject);
                _healthPoint -= _damageArrow;
            }


            if (collision.gameObject.tag == "Biter" && _isDamage)
            {
                _isDamage = false;
                _healthPoint -= _damageBiter;
            }

        }
        private void Update()
        {

            if (!_isDamage)

            {
                _timer += Time.deltaTime;

                if (_timer > _timerBetweenDamage)
                {
                    _isDamage = true;
                    _timer = 0;
                }
            }
        }
    }
}
