using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Script.General
{
    public class MenuSceneLoader : MonoBehaviour
    {
        /*
            �������� ����� ������ "MenuSceneLoader" - ������������� ������� ����� ���������� ������.
        */

        private const byte _sceneId = 2;

        public void LoadGame()
        {
            SceneManager.LoadScene(_sceneId);
        }
    }
}
