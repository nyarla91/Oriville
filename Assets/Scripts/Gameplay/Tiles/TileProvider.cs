using System;
using System.Collections.Generic;
using System.Linq;
using Extentions;
using UnityEngine;

namespace Gameplay.Tiles
{
    public class TileProvider : MonoBehaviour
    {
        [SerializeField] private TileType[] _types;
        [SerializeField] private TileFactory _factory;

        private List<Tile> Tiles { get; } = new();
        
        public Tile PendingTile { get; private set; }

        public event Action<Tile[]> TilePlaced;

        private void Start()
        {
            SpawnPendingTile();
        }

        public void PlacePendingTile()
        {
            PendingTile.Place();
            Tiles.Add(PendingTile);
            TilePlaced?.Invoke(Tiles.ToArray());
            SpawnPendingTile();
        }

        public void ShowPendingTileAtPosition(Vector3 position)
        {
            PendingTile.gameObject.SetActive(true);
            PendingTile.Move(position);
        }

        public void HidePendingTile()
        {
            PendingTile.gameObject.SetActive(false);
        }

        private void SpawnPendingTile()
        {
            TileType type = _types.PickRandom();
            PendingTile = _factory.SpawnTile(type);
        }
    }
}