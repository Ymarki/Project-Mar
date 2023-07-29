using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private bool _isLoad = true;
    [SerializeField] private int _sceneId;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && _isLoad)
        {
            _isLoad = false;
            LoadGame();
        }
    }
    private void LoadGame()
    {
        SceneManager.LoadScene(_sceneId);
    }

}
