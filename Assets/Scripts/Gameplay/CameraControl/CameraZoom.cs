using UnityEngine;

namespace Gameplay.CameraControl
{
    [RequireComponent(typeof(Camera))]
    [RequireComponent(typeof(CameraInput))]
    public class CameraZoom : MonoBehaviour
    {
        [SerializeField] private float _minSize;
        [SerializeField] private float _maxSize;
        [SerializeField] private float _speed;
        
        private Camera _camera;
        private CameraInput _input;
        private Camera Camera => _camera ??= GetComponent<Camera>(); 
        private CameraInput Input => _input ??= GetComponent<CameraInput>(); 
        

        private void Update()
        {
            float delta = Input.Zoom * _speed * Time.deltaTime;
            Camera.orthographicSize = Mathf.Clamp(Camera.orthographicSize - delta, _minSize, _maxSize);
        }

        private void OnValidate()
        {
            if (_minSize > _maxSize)
                _minSize = _maxSize;
        }
    }
}