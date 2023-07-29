using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadMenu : MonoBehaviour
{
    private const byte _sceneId = 1;

    public void LoadGame()
    {
        SceneManager.LoadScene(_sceneId);
    }
}
