using Extentions;
using TMPro;
using UnityEngine;
using Zenject;

namespace Gameplay.Tiles
{
    public class TilePointsView : RectTransformable
    {
        [SerializeField] private TMP_Text _counter;
        [SerializeField] private Color _defaultColor;
        [SerializeField] private Color _reductionColor;
        [SerializeField] private Color _incrementColor;

        private Tile _tile;
        private int _actualPoints;
        
        [Inject] private Camera MainCamer { get; set; }
        
        public void Init(Tile tile)
        {
            _tile = tile;
            _tile.PointsChanged += UpdatePoints;
            _tile.PointsPreviewStarted += PreviewPoints;
            _tile.PointsPreviewEnded += ReturnActualPoints;
        }

        private void UpdatePoints(int points)
        {
            _actualPoints = points;
            _counter.color = _defaultColor;
            ShowPoints(points);
        }

        private void PreviewPoints(int points)
        {
            _counter.color = points == _actualPoints ? _defaultColor : (points > _actualPoints ? _incrementColor : _reductionColor);
            ShowPoints(points);
        }

        private void ReturnActualPoints()
        {
            _counter.color = _defaultColor;
            ShowPoints(_actualPoints);
        }

        private void ShowPoints(int points) => _counter.text = points.ToString();

        private void Update()
        {
            RectTransform.anchoredPosition = MainCamer.WorldToScreenPoint(_tile.PointsAnchor.position);
        }
    }
}