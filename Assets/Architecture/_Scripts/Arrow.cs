using UnityEngine;

namespace _Script
{
    public class Arrow : MonoBehaviour
    {
        /*
            Основной смысл класса "Arrow" - составить описание объекта "Arrow".

            1) Скорость, с которой стрела летит.
            2) Её урон по игроку, в случае если стрела попадёт в игрока.

            А так же, удалять стрелу в том случае, если стрела летит слишком долго или стрела касается
            определённых объектов обладающий тэгом "Object"
        */

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
}