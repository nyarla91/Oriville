using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    public abstract class TileRule : ScriptableObject
    {
        protected abstract int CalculatePoints(TileBiome[] adjacentBiomes);
    }
    
}