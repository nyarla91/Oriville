using System;
using System.Linq;
using Gameplay.Tiles;
using Zenject;

namespace Gameplay.Score
{
    public class ScoreCounter
    {

        public int Current { get; private set; }

        public event Action<int> CurrentChanged;

        [Inject]
        public ScoreCounter(TileProvider tileProvider)
        {
            tileProvider.TilePlaced += RecalculateScore;
        }

        private void RecalculateScore(Tile[] tiles)
        {
            Current = tiles.Sum(tile => tile.Points);
            CurrentChanged?.Invoke(Current);
        }
    }
}