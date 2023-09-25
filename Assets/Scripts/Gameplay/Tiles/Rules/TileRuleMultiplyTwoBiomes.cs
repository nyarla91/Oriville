using System.Linq;
using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    [CreateAssetMenu(menuName = "Tile Rules/Multiply Two Biomes")]
    public class TileRuleMultiplyTwoBiomes : TileRule
    {
        [SerializeField] private TileBiome _firstBiome;
        [SerializeField] private TileBiome _secondBiome;

        public override int CalculatePoints(TileBiome[] adjacentBiomes) =>
            ValidTiles(adjacentBiomes, _firstBiome) * ValidTiles(adjacentBiomes, _secondBiome);
    }
}