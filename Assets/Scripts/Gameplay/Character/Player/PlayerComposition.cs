using UnityEngine;

namespace Gameplay.Character.Player
{
    public class PlayerComposition : MonoBehaviour
    {
        private PlayerControls _controls;

        public PlayerControls Controls => _controls ??= GetComponent<PlayerControls>();
    }
}