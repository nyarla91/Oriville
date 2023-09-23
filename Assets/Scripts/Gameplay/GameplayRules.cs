using UnityEngine;

namespace Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay Rules", order = 0)]
    public class GameplayRules : ScriptableObject
    {
        [SerializeField] private float _gridSize;

        public float GridSize => _gridSize;
    }
}