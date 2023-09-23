using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    [CreateAssetMenu(menuName = "Tile Rules/Different Biomes")]
    public class TileRuleDifferentBiomes : TileRule
    {
        [SerializeField] private int _pointsPerBiome;

        public override int CalculatePoints(TileBiome[] adjacentBiomes)
        {
            int result = 0;
            List<TileBiome> countedBiomes = new();
            foreach (TileBiome biome in adjacentBiomes)
            {
                if (countedBiomes.Contains(biome))
                    continue;
                result += _pointsPerBiome;
                countedBiomes.Add(biome);
            }
            return result;
        }
    }
}