using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
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
