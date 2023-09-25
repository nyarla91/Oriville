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

        private void Awake()
        {
            _model.CurrentChanged += UpdateScore;
        }

        private void UpdateScore(int score)
        {
            _value.text = $"{score}/{_boardBounds.ExpandRequirement}";
        }
    }
}