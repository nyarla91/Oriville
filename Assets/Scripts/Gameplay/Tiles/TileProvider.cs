using Extentions;
using UnityEngine;

namespace Gameplay.Tiles
{
    public class TileProvider : MonoBehaviour
    {
        [SerializeField] private TileType[] _types;

        public TileType CurrentType { get; private set; }

        public void DrawTile()
        {
            CurrentType = _types.PickRandomElement();
        }
    }
}