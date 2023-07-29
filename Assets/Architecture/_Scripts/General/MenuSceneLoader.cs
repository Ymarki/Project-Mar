using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneLoader : MonoBehaviour
{
    private const byte _sceneId = 2;

    public void LoadGame()
    {
        SceneManager.LoadScene(_sceneId);
    }

}
