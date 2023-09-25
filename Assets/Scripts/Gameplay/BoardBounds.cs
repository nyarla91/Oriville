using Extentions;
using Gameplay.Score;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class BoardBounds : Transformable
    {
        [SerializeField] private ScoreCounter _scoreCounter;

        private int _level = 1;
        private float _expandREquirementPerSquare;

        public int ExpandRequirement => (int) (_expandREquirementPerSquare * SquaresInBounds);
        public int SquaresInBounds => (2 * _level + 1) * (2 * _level + 1);

        [Inject] private GameplayRules Rules { get; set; }
        
        private void Awake()
        {
            _scoreCounter.CurrentChanged += CheckScoreRequirement;
        }

        private void Start()
        {
            _expandREquirementPerSquare = Rules.StartingExpandRequirementPerSquare;
            SetScaleForCurrentLevel();
        }

        private void CheckScoreRequirement(int score)
        {
            if (score >= ExpandRequirement)
                Expand();
        }

        private void Expand()
        {
            _level++;
            SetScaleForCurrentLevel();
            _expandREquirementPerSquare = Rules.LerpExpandRequirement(_expandREquirementPerSquare);
        }

        private void SetScaleForCurrentLevel()
        {
            Transform.localScale = Vector3.one * (_level * 2 + 1) * Rules.GridSize / 2;
        }
    }
}