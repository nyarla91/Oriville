using System;
using DG.Tweening;
using Extentions;
using TMPro;
using UnityEngine;
using Zenject;

namespace Gameplay.Score
{
    public class ScoreView : RectTransformable
    {
        [SerializeField] private BoardBounds _boardBounds;
        [SerializeField] private TMP_Text _value;
        [SerializeField] private TMP_Text _reuirementValue;

        [Inject] private ScoreCounter Model { get; }
        
        private void Awake()
        {
            Model.CurrentChanged += UpdateScore;
        }

        private void UpdateScore(int score)
        {
            RectTransform.DOComplete();
            RectTransform.DOShakeScale(0.2f, Vector3.one * 0.5f);
            _value.text = $"{score}";
            Debug.Log(_reuirementValue);
            _reuirementValue.text = $"/{_boardBounds.ExpandRequirement}";
        }
    }
}