using System;
using TMPro;
using UnityEngine;

namespace Gameplay.Score
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private BoardBounds _boardBounds;
        [SerializeField] private ScoreCounter _model;
        [SerializeField] private TMP_Text _value;
        [SerializeField] private TMP_Text _reuirementValue;

        private void Awake()
        {
            _model.CurrentChanged += UpdateScore;
        }

        private void UpdateScore(int score)
        {
            _value.text = $"{score}";
            Debug.Log(_reuirementValue);
            _reuirementValue.text = $"/{_boardBounds.ExpandRequirement}";
        }
    }
}