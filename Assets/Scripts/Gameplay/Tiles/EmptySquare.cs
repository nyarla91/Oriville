using Extentions;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Gameplay.Tiles
{
    public class EmptySquare : SquareEntity, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [Inject] private ContainerInstantiator Instantiator { get; }
        [Inject] private TileProvider TileProvider { get; }
        [Inject] private TileFactory TileFactory { get; }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            SpawnTileHere();
            SpawnSquaresAround();
            Destroy(gameObject);
        }

        private void SpawnTileHere()
        {
            TileFactory.SpawnTile(TileProvider.CurrentType, Transform.position);
        }

        private void SpawnSquaresAround()
        {
            ForeachAdjacentTile((direction, tile) =>
            {
                if (tile != null)
                    return;
                Vector3 position = GetAdjacentSquareInDirection(direction);
                Instantiator.Instantiate<Transform>(gameObject, position);
            });
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            ForeachAdjacentTile((direction, tile) =>
            {
                if (tile == null)
                    return;
                tile.StartPointsPreview( - direction, TileProvider.CurrentType.Biome);
            });
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            ForeachAdjacentTile((_, tile) =>
            {
                if (tile == null)
                    return;
                tile.EndPointsPreview();
            });
        }
    }
}