using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Script.General
{
    public class MenuSceneLoader : MonoBehaviour
    {
        /*
            Основной смысл класса "MenuSceneLoader" - Инициализация игровой сцены начального уровня.
        */

        private const byte _sceneId = 2;

        public void LoadGame()
        {
            SceneManager.LoadScene(_sceneId);
        }
    }
}
