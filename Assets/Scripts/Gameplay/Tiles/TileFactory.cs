using Extentions;
using UnityEngine;
using Zenject;

namespace Gameplay.Tiles
{
    public class TileFactory : MonoBehaviour
    {
        [SerializeField] private GameObject _tilePrefab;
        [SerializeField] private GameObject _tilePointsViewPrefab;
        [SerializeField] private Canvas _hud;

        [Inject] private ContainerInstantiator Instantiator { get; set; }
        [Inject] private GameplayRules Rules { get; set; }

        public void SpawnTile(TileType type, Vector3 position)
        {
            position = position.SnapToGrid(Vector3.one * Rules.GridSize).WithY(0);
            Tile tile = Instantiator.Instantiate<Tile>(_tilePrefab, position);
            tile.Init(type);
            Instantiate(type.View, tile.Transform);
            TilePointsView view = Instantiator.Instantiate<TilePointsView>(_tilePointsViewPrefab, Vector3.zero, _hud.transform);
            view.Init(tile);
        }
    }
}