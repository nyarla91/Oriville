using Input;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Gameplay
{
    public class Cursor : MonoBehaviour
    {
        [Inject] private InputDeviceWatcher InputDeviceWatcher { get; set; }

        private void Update()
        {
            bool gamepadScheme = InputDeviceWatcher.CurrentInputScheme == InputScheme.Gamepad;
            if (gamepadScheme)
            {
                Mouse.current.WarpCursorPosition(new Vector2(Screen.width, Screen.height) / 2);
            }
            /*
            UnityEngine.Cursor.lockState = gamepadScheme ? CursorLockMode.Locked : CursorLockMode.None;
            UnityEngine.Cursor.visible = !gamepadScheme;
            */
        }
    }
}