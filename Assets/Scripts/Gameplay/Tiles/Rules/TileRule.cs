using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    public abstract class TileRule : ScriptableObject
    {
        public abstract int CalculatePoints(TileBiome[] adjacentBiomes);
    }
    
}