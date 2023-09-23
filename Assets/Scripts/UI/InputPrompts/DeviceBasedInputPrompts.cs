using System;
using Input;
using UnityEngine;
using Zenject;

namespace UI.InputPrompts
{
    public abstract class DeviceBasedInputPrompts<TGraphics, TPrompt> : MonoBehaviour
    {
        [SerializeField] private TPrompt _keyboardMouse;
        [SerializeField] private TPrompt _xbox;
        [SerializeField] private TPrompt _playStation;

        private TGraphics _graphics;

        protected TGraphics Graphics => _graphics ??= GetComponent<TGraphics>();

        [Inject] private InputDeviceWatcher InputDeviceWatcher { get; set; }

        private void Awake()
        {
            InputDeviceWatcher.OnGamepadModelChanged += OnGamepadModelChanged;
            InputDeviceWatcher.OnInputSchemeChanged += OnInputSchemeChanged;
        }

        private void Start()
        {
            UpdatePrompts();
        }

        private void OnGamepadModelChanged(GamepadModel _) => UpdatePrompts();
        private void OnInputSchemeChanged(InputScheme _) => UpdatePrompts();

        private void UpdatePrompts()
        {
            ApplyPrompt(InputDeviceWatcher.CurrentInputScheme switch
            {
                InputScheme.KeyboardMouse => _keyboardMouse,
                InputScheme.None => _keyboardMouse,
                InputScheme.Gamepad => InputDeviceWatcher.CurrentGamepadModel switch
                {
                    GamepadModel.PlayStation => _playStation,
                    GamepadModel.Xbox => _xbox,
                    GamepadModel.Switch => _xbox,
                    GamepadModel.None => _xbox,
                    _ => throw new ArgumentOutOfRangeException()
                },
                _ => throw new ArgumentOutOfRangeException()
            });
        }

        protected abstract void ApplyPrompt(TPrompt prompt);

        private void OnDestroy()
        {
            InputDeviceWatcher.OnGamepadModelChanged -= OnGamepadModelChanged;
            InputDeviceWatcher.OnInputSchemeChanged -= OnInputSchemeChanged;
        }
    }
}