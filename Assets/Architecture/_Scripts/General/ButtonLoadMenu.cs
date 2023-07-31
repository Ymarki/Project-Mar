using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Script.General
{
    public class ButtonLoadMenu : MonoBehaviour
    {
        /*
            �������� ����� ������ "ButtonLoadMenu" - 
            �� ������� �� ������ "Back in menu" �� ����� ����, ��������� ����� �������� ����.
        */

        private const byte _sceneId = 1;

        public void LoadGame()
        {
            SceneManager.LoadScene(_sceneId);
        }
    }
}
