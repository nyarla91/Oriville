using Extentions;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Gameplay.Tiles
{
    public class EmptySquare : SquareEntity, IPointerClickHandler
    {
        [Inject] private ContainerInstantiator Instantiator { get; }
        [Inject] private TileProvider TileProvider { get; }
        [Inject] private TileFactory TileFactory { get; }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            SpawnTileHere();
            SpawnSquaresAround();
        }

        private void SpawnTileHere()
        {
            TileFactory.SpawnTile(TileProvider.CurrentType, Transform.position);
        }

        private void SpawnSquaresAround()
        {
            Vector3[] directions = {Vector3.forward, Vector3.back, Vector3.left, Vector3.right};
            foreach (Vector3 direction in directions)
            {
                if (GetAdjacentTileInDirection(direction) != null)
                    continue;
                Vector3 position = GetAdjacentSquareInDirection(direction);
                Instantiator.Instantiate<Transform>(gameObject, position);
            }
        }
    }
}