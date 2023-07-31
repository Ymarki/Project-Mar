using UnityEngine;

namespace _Script.Platform
{
    public class DestructionPlatformModel : MonoBehaviour
    {
        /* 
        Основной смысл класса "DestructionPlatformModel" - составить описания объекта "DestructionPlatform"

        1) В течении какого времени будет разрушена платформа.
        2) ограничитель срабатывания одного раза.
        */
        [SerializeField][Range(0, 100)] private float _secondToDestroy;

        private bool _canDestroy = true;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player" && _canDestroy)
            {

                _canDestroy = false;

                Destroy(gameObject.transform.parent.gameObject, _secondToDestroy);

            }
        }
    }
}
