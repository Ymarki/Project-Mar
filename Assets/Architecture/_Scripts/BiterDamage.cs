using UnityEngine;

public class BiterDamage : MonoBehaviour
{
    [SerializeField] private int _damage;
    public int Damage()
    {
        return _damage;
    }
}
