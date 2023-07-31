using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Script.General
{
    public class ButtonLoadMenu : MonoBehaviour
    {
        /*
            Основной смысл класса "ButtonLoadMenu" - 
            По нажатии на кнопку "Back in menu" во время игры, Загружать сцену игрового меню.
        */

        private const byte _sceneId = 1;

        public void LoadGame()
        {
            SceneManager.LoadScene(_sceneId);
        }
    }
}
