using System;
using Extentions;
using Input;
using TMPro;
using UnityEngine;
using Zenject;

namespace UI
{
    public class DeviceBasedInputPrompts : LazyGetComponent<TMP_Text>
    {
        [SerializeField] private TMP_SpriteAsset _keyboardMouse;
        [SerializeField] private TMP_SpriteAsset _xbox;
        [SerializeField] private TMP_SpriteAsset _playStation;

        [Inject] private InputDeviceWatcher InputDeviceWatcher { get; set; }

        private void Awake()
        {
            InputDeviceWatcher.OnGamepadModelChanged += OnGamepadModelChanged;
            InputDeviceWatcher.OnInputSchemeChanged += OnInputSchemeChanged;
            UpdatePrompts();
        }

        private void OnGamepadModelChanged(GamepadModel _) => UpdatePrompts();
        private void OnInputSchemeChanged(InputScheme _) => UpdatePrompts();

        private void UpdatePrompts()
        {
            Lazy.spriteAsset = InputDeviceWatcher.CurrentInputScheme switch
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
            };
        }
    }
}