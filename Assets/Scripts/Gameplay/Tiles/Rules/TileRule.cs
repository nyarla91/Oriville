using System.Linq;
using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    public abstract class TileRule : ScriptableObject
    {
        public abstract int CalculatePoints(TileBiome[] adjacentBiomes);

        protected int ValidTiles(TileBiome[] tiles, TileBiome validator) =>
            validator == TileBiome.None ? tiles.Length : tiles.Count(tile => tile == validator);
    }
    
}