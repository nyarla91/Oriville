using System;
using System.Linq;
using Gameplay.Tiles;
using UnityEngine;

namespace Gameplay.Score
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private TileProvider _tileProvider;

        public int Current { get; private set; }

        public event Action<int> CurrentChanged;

        private void Awake()
        {
            _tileProvider.TilePlaced += RecalculateScore;
        }

        private void RecalculateScore(Tile[] tiles)
        {
            Current = tiles.Sum(tile => tile.Points);
            CurrentChanged?.Invoke(Current);
        }
    }
}