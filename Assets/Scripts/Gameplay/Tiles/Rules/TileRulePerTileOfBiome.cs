using System.Linq;
using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    [CreateAssetMenu(menuName = "Tile Rules/Per Tile Of Biome")]
    public class TileRulePerTileOfBiome : TileRule
    {
        [SerializeField] private TileBiome _biome;
        [SerializeField] private int _pointsPerTile;
        [SerializeField] private int _tilesCap = 4;
        [SerializeField] private bool _zeroAfterCap;

        public override int CalculatePoints(TileBiome[] adjacentBiomes)
        {
            int validTiles = adjacentBiomes.Count(biome => biome == _biome);
            if (validTiles > _tilesCap)
                validTiles = _zeroAfterCap ? 0 : _tilesCap;
            return validTiles * _pointsPerTile;
        }
    }
}