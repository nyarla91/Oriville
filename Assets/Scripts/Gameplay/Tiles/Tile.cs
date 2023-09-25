using System;
using System.Collections.Generic;
using Extentions;
using Gameplay.Score;
using UnityEngine;
using Zenject;

namespace Gameplay.Tiles
{
    public class Tile : SquareEntity
    {
        [SerializeField] private AudioSource _sound;
        [SerializeField] private Transform _pointsAnchor;

        private bool _placed;
        private TileType _type;

        public int Points { get; private set; }

        public Transform PointsAnchor => _pointsAnchor;

        public event Action<int> PointsChanged;
        public event Action<int> PointsPreviewStarted;
        public event Action PointsPreviewEnded;
        public event Action Placed;

        public TileBiome Biome => _type.Biome;
        
        [Inject] private ScoreCounter ScoreCounter { get; set; }
        
        public void Init(TileType type)
        {
            _type = type;
        }

        public void Place()
        {
            if (_placed)
                return;
            if (!gameObject.activeSelf)
                throw new InvalidOperationException("Tile gameObject must be active in order to be placed");
            _placed = true;
            Placed?.Invoke();
            RecalculatePoints();
            AdjacentTiles.Foreach(tile => tile?.RecalculatePoints());
            _sound.Play();
        }

        public void Move(Vector3 position)
        {
            Transform.position = position.WithY(0).SnapToGrid(GridSize);
        }

        public void StartPointsPreview()
        {
            List<TileBiome> previewTileBiomes = new();
            ForeachAdjacentEntity<Tile>((_, tile) =>
            {
                if (tile == null)
                    return;
                previewTileBiomes.Add(tile.Biome);
            });
            int previewPoints = _type.Rule.CalculatePoints(previewTileBiomes.ToArray());
            PointsPreviewStarted?.Invoke(previewPoints);
        }

        public void EndPointsPreview() => PointsPreviewEnded?.Invoke();

        private void RecalculatePoints()
        {
            EndPointsPreview();
            List<TileBiome> biomes = new();
            ForeachAdjacentEntity<Tile>((_, tile) =>
            {
                if (tile != null)
                    biomes.Add(tile.Biome);
            });
            Points = _type.Rule.CalculatePoints(biomes.ToArray());
            PointsChanged?.Invoke(Points);
        }
    }
}