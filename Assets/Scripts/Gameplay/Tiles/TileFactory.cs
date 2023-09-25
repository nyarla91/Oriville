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

        public Tile SpawnTile(TileType type)
        {
            Tile tile = Instantiator.Instantiate<Tile>(_tilePrefab, Vector3.zero);
            tile.Init(type);
            
            TileView view = Instantiate(type.View, tile.Transform).GetComponent<TileView>();
            view.Init(tile);
            
            TilePointsView pointsView = Instantiator.Instantiate<TilePointsView>(_tilePointsViewPrefab, Vector3.zero, _hud.transform);
            pointsView.Init(tile);
            
            tile.gameObject.SetActive(false);
            return tile;
        }
    }
}