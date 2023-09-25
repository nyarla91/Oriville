using UnityEngine;

namespace Gameplay
{
    [CreateAssetMenu(menuName = "Gameplay Rules", order = 0)]
    public class GameplayRules : ScriptableObject
    {
        [SerializeField] private float _gridSize;
        [SerializeField] private float _startingExpandRequirementPerSquare;
        [SerializeField] private float _maxExpandRequirementPerSquare;
        [SerializeField] [Range(0, 1)] private float _expandRequirementLerpT;

        public float GridSize => _gridSize;

        public float StartingExpandRequirementPerSquare => _startingExpandRequirementPerSquare;

        public float LerpExpandRequirement(float expandRequirement)
        {
            return Mathf.Lerp(expandRequirement,
                _maxExpandRequirementPerSquare, _expandRequirementLerpT);
        }
    }
}