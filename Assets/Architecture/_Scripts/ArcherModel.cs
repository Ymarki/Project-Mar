using UnityEngine;

public class ArcherModel : MonoBehaviour
{

    [SerializeField] private GameObject _arrow;
    [SerializeField] private GameObject _player;

    [SerializeField] private float _timeBetweenShot;
    [SerializeField] private float _radiusShot;

    private float _timer;
    private float _pointAngle;
    private float _radiusCanShot;

    private bool _canShot;

    private Vector2 _rotation;
    
    private void FixedUpdate()
    {
        _rotation = _player.transform.position - transform.position;
        _pointAngle = Mathf.Atan2(_rotation.y,_rotation.x) * Mathf.Rad2Deg;
        _radiusCanShot = _rotation.magnitude;
    }
    private void Update()
    {
        if (!_canShot)
        {
            _timer += Time.deltaTime;
            if (_timer > _timeBetweenShot)
            {
                _canShot = true;
                _timer = 0;
            }
        }
        if (_canShot && _radiusCanShot < _radiusShot)
        {
            Instantiate(_arrow, new Vector2(transform.position.x, transform.position.y), Quaternion.Euler(0, 0, _pointAngle - 90f));
            _canShot = false;
        }
    }

}
