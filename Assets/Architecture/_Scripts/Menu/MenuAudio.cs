using UnityEngine;

public class MenuAudio : MonoBehaviour
{
    [SerializeField] private bool _canAudio;
    [SerializeField] private GameObject _gameObjectMute;
    [SerializeField] private GameObject _gameObjectUnMute;
    public void Mute()
    {
        if (_canAudio)
        {
            _canAudio = false;
            _gameObjectMute.SetActive(false);
            _gameObjectUnMute.SetActive(true);
        }
        else
        {
            _canAudio = true;
            _gameObjectMute.SetActive(true);
            _gameObjectUnMute.SetActive(false);
        }
    }
}
