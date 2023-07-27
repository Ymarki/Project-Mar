using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] private Camera _camera;

    [SerializeField] private GameObject _cameraTarget;

    private void Update()
    {
        if (_camera.transform.position.x < _cameraTarget.transform.position.x)
        {
            transform.position = new Vector3(_cameraTarget.transform.position.x, _camera.transform.position.y, _camera.transform.position.z);
        }
    }
}
