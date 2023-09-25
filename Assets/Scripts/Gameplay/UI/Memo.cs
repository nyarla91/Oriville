using System;
using DG.Tweening;
using Extentions;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Gameplay.UI
{
    public class Memo : RectTransformable
    {
        [SerializeField] private float _openDuration;
        
        [Inject] private GameplayActions Actions { get; }

        private float _width;
        
        private bool _openned = true;

        public void Open() => Toggle(true);
        
        public void Close() => Toggle(false);

        private void Switch(InputAction.CallbackContext _) => Toggle( ! _openned);
        
        private void Toggle(bool openned)
        {
            _openned = openned;
            Vector2 targetPosition = new Vector2(_openned ? 0 : -_width, 0);
            RectTransform.DOKill();
            RectTransform.DOAnchorPos(targetPosition, _openDuration);
        }

        private void Start()
        {
            _width = RectTransform.rect.width;
            Actions.UI.ToggleMemo.started += Switch;
        }
    }
}