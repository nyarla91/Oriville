using System.Linq;
using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    [CreateAssetMenu(menuName = "Tile Rules/Per Tile Of Biome")]
    public class TileRulePerTileOfBiome : TileRule
    {
        [SerializeField] private TileBiome _biome;
        [SerializeField] private int _pointsPerTile;

        public override int CalculatePoints(TileBiome[] adjacentBiomes)
        {
            int validTiles = adjacentBiomes.Where(biome => biome == _biome).ToArray().Length;
            return validTiles * _pointsPerTile;
        }
    }
}