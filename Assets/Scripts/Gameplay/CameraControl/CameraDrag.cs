using Extentions;
using Extentions.Pause;
using Input;
using UnityEngine;
using Zenject;

namespace Gameplay.CameraControl
{
    [RequireComponent(typeof(Camera))]
    [RequireComponent(typeof(CameraInput))]
    public class CameraDrag : Transformable
    {
        [SerializeField] private float _mouseSpeed;
        [SerializeField] private float _thumbstickSpeed;
            
        private Camera _camera;
        private CameraInput _input;
        private Camera Camera => _camera ??= GetComponent<Camera>();
        private CameraInput Input => _input ??= GetComponent<CameraInput>();

        [Inject] private InputDeviceWatcher InputDeviceWatcher { get; set; }
        [Inject] private IPauseRead PauseRead { get; }

        private void Update()
        {
            if (PauseRead.IsPaused)
                return;
            if (Input.IsDragging)
                MoveScreen( - Input.MouseMove * _mouseSpeed * Time.deltaTime);
            if (InputDeviceWatcher.CurrentInputScheme == InputScheme.Gamepad)
                MoveScreen(Input.ThumbstickMove * _thumbstickSpeed * Time.deltaTime);
        }

        private void MoveScreen(Vector2 screenDelta)
        {
            Vector3 delta = Transform.forward.WithY(0).normalized * screenDelta.y +
                            Transform.right.WithY(0).normalized * screenDelta.x;

            Transform.position += delta * Camera.orthographicSize;
        }
    }
}