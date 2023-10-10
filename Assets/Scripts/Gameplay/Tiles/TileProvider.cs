using System;
using System.Collections.Generic;
using Extentions;
using UnityEngine;
using Zenject;

namespace Gameplay.Tiles
{
    public class TileProvider
    {
        private List<Tile> Tiles { get; } = new();
        
        public Tile PendingTile { get; private set; }

        private TileFactory Factory { get; }
        private GameplayRules GameplayRules { get; }
        
        public event Action<Tile[]> TilePlaced;

        [Inject]
        public TileProvider(TileFactory factory, GameplayRules gameplayRules)
        {
            GameplayRules = gameplayRules;
            Factory = factory;
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

        public void SpawnFirstTile()
        {
            if (PendingTile != null)
                return;
            SpawnPendingTile();
        }

        private void SpawnPendingTile()
        {
            TileType type = GameplayRules.TilePool.PickRandom();
            PendingTile = Factory.SpawnTile(type);
        }
    }
}