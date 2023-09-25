using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Gameplay.CameraControl
{
    public class CameraInput : MonoBehaviour
    {
        private GameplayActions _actions;

        public bool IsDragging { get; private set; }
        public Vector2 MouseMove => _actions.Camera.MouseMove.ReadValue<Vector2>() / new Vector2(Screen.width, Screen.height);
        public Vector2 ThumbstickMove => _actions.Camera.ThumbstickMove.ReadValue<Vector2>();
        public float Zoom => _actions.Camera.Zoom.ReadValue<float>();

        [Inject]
        private void Construct(GameplayActions actions)
        {
            _actions = actions;
            _actions.Camera.DragButton.started += StartDrag;
            _actions.Camera.DragButton.canceled += EndDrag;
        }

        private void StartDrag(InputAction.CallbackContext _) => IsDragging = true;
        private void EndDrag(InputAction.CallbackContext _) => IsDragging = false;
    }
}