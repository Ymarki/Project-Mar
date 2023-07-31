using UnityEngine;

namespace _Script
{
    public class BiterDamage : MonoBehaviour
    {
        /* 
        Основной смысл класса "BiterDamage" - устанавливать значение урона для объекта "Biter"
        */

        [SerializeField] private int _damage;

        public int Damage()
        {
            return _damage;
        }
    }
}