using System;
using System.Collections.Generic;
using System.Linq;
using Extentions;
using UnityEngine;

namespace Gameplay.Tiles
{
    public class Tile : SquareEntity
    {
        [SerializeField] private Transform _pointsAnchor;
        
        private TileType _type;


        private int Points { get; set; }

        public Transform PointsAnchor => _pointsAnchor;

        public event Action<int> PointsChanged;
        public event Action<int> PointsPreviewStarted;
        public event Action PointsPreviewEnded;

        private TileBiome Biome => _type.Biome;
        
        public void Init(TileType type)
        {
            _type = type;
        }

        private void Start()
        {
            RecalculatePoints();
            AdjacentTiles.Foreach(tile => tile?.RecalculatePoints());
        }

        public void StartPointsPreview(Vector3 newTileDirection, TileBiome newTileBiome)
        {
            List<TileBiome> previewTileBiomes = new();
            ForeachAdjacentTile((direction, tile) =>
            {
                if (direction.Equals(newTileDirection))
                    previewTileBiomes.Add(newTileBiome);
                else if (tile != null)
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
            ForeachAdjacentTile((_, tile) =>
            {
                if (tile != null)
                    biomes.Add(tile.Biome);
            });
            Points = _type.Rule.CalculatePoints(biomes.ToArray());
            PointsChanged?.Invoke(Points);
        }
    }
}