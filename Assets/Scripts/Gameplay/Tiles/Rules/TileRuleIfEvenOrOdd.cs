using Extentions;
using UnityEngine;

namespace Gameplay.Tiles.Rules
{
    [CreateAssetMenu(menuName = "Tile Rules/If Even Or Odd")]
    public class TileRuleIfEvenOrOdd : TileRule
    {
        [SerializeField] private bool _odd;
        [SerializeField] private int _points;
        
        public override int CalculatePoints(TileBiome[] adjacentBiomes)
        {
            return _odd != adjacentBiomes.Length.IsEven() ? _points : 0;
        }
    }
}