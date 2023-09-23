using UnityEngine;

namespace Gameplay.Character.Player
{
    public class PlayerControls : MonoBehaviour
    {
        private GameplayActions _actions;

        public Vector2 MoveVector => _actions.Player.Move.ReadValue<Vector2>();

        private void Awake()
        {
            _actions = new GameplayActions();
            _actions.Enable();
        }
    }
}