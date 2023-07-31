using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Script.General
{
    public class Bootstrap : MonoBehaviour
    {
        /*
            �������� ����� ������ "Bootstrap" - ������������� ���������� ������.
        */

        private const byte _sceneId = 1;

        private void Start()
        {
            LoadGame();
        }

        private void LoadGame()
        {
            SceneManager.LoadScene(_sceneId);
        }
    }
}

