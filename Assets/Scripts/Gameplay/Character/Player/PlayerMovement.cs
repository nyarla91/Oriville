using Extentions;
using UnityEngine;

namespace Gameplay.Character.Player
{
    public class PlayerMovement : LazyGetComponent<PlayerComposition>
    {
        [SerializeField] private float _maxSpeed;
        [SerializeField] private float _acceleration;

        private Vector3 _velocity;

        private Transform _mainCamera;
        public Transform MainCamera => _mainCamera ??= Camera.main.transform;
        private Movable _movable;
        public Movable Movable => _movable ??= GetComponent<Movable>();
        
        private void FixedUpdate()
        {
            Move(Lazy.Controls.MoveVector);
        }

        private void Move(Vector2 screenInput)
        {
            Vector3 targetVelocity = MainCamera.forward.WithY(0).normalized * screenInput.y + MainCamera.right * screenInput.x;
            targetVelocity *= _maxSpeed;
            _velocity = Vector3.MoveTowards(_velocity, targetVelocity, _acceleration * Time.fixedTime);
            Movable.Velocity = _velocity;
        }
    }
}