using Extentions;

namespace Gameplay.Tiles
{
    public class Tile : SquareEntity
    {
        private TileType _type;
        
        public TileBiome Biome => _type.Biome;
        
        public void Init(TileType type)
        {
            _type = type;
        }
    }
}