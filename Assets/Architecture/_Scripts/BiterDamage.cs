using UnityEngine;

namespace _Script
{
    public class BiterDamage : MonoBehaviour
    {
        /* 
        �������� ����� ������ "BiterDamage" - ������������� �������� ����� ��� ������� "Biter"
        */

        [SerializeField] private int _damage;

        public int Damage()
        {
            return _damage;
        }
    }
}