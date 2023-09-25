using System.Linq;
using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    [CreateAssetMenu(menuName = "Tile Rules/Count Table Of Biome")]
    public class TileRuleCountTable : TileRule
    {
        [SerializeField] private TileBiome _biome;
        [SerializeField] private int[] _pointsPerCount = new int[5];
        
        public override int CalculatePoints(TileBiome[] adjacentBiomes)
        {
            return _pointsPerCount[ValidTiles(adjacentBiomes, _biome)];
        }

        private void OnValidate()
        {
            if (_pointsPerCount.Length != 5)
                _pointsPerCount = new int[5];
        }
    }
}