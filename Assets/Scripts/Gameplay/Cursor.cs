using Extentions.Pause;
using Input;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Gameplay
{
    public class Cursor : MonoBehaviour
    {
        [Inject] private InputDeviceWatcher InputDeviceWatcher { get; set; }

        [Inject] private IPauseRead PauseRead { get; set; }
        
        private void Update()
        {
            bool gamepadScheme = InputDeviceWatcher.CurrentInputScheme == InputScheme.Gamepad;
            if (!gamepadScheme)
                return;
            Vector2 screenPosition = PauseRead.IsPaused ? Vector2.zero : new Vector2(Screen.width, Screen.height) / 2;
            Mouse.current.WarpCursorPosition(screenPosition);
        }
    }
}