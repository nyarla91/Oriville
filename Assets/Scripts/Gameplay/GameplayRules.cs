using System.Collections.Generic;
using System.Linq;
using Gameplay.Tiles;
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
        [SerializeField] private TileType[] _tilePool;

        public float GridSize => _gridSize;

        public float StartingExpandRequirementPerSquare => _startingExpandRequirementPerSquare;

        public IEnumerable<TileType> TilePool => _tilePool;

        public float LerpExpandRequirement(float expandRequirement)
        {
            return Mathf.Lerp(expandRequirement,
                _maxExpandRequirementPerSquare, _expandRequirementLerpT);
        }
    }
}