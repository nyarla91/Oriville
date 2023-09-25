using System.Threading.Tasks;
using Extentions;
using Extentions.Pause;
using GameStates;
using Input;
using UI;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Gameplay.UI
{
    public class InGameMenu : LazyGetComponent<Menu>
    {
        [Inject] private SceneLoader SceneLoader { get; set; }
        [Inject] private IPauseRead Pause { get; set; }

        public void Quit() => Application.Quit();
        public void Surrender()
        {
            Debug.Log(90);
            SceneLoader.LoadMainMenu();
        }

        private void Awake()
        {
            Lazy.OnOpen += UnsubscribeMenuOpen;
            Lazy.OnClose += SubscribeMenuOpen;
        }
        
        private async void SubscribeMenuOpen()
        {
            await Task.Delay(1);
            MenuControls.Actions.Always.OpenMenu.started += OpenMenuIfClosed;
        }

        private void UnsubscribeMenuOpen() => MenuControls.Actions.Always.OpenMenu.started -= OpenMenuIfClosed;

        private void OpenMenuIfClosed(InputAction.CallbackContext _)
        {
            if (Pause.IsPaused)
                return;
            Lazy.Open();
        }

        private void OnDestroy()
        {
            if ( ! Lazy.IsOpened)
                UnsubscribeMenuOpen();
        }
    }
}