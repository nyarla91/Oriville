using Extentions;
using UnityEngine;
using Zenject;

namespace Gameplay.Tiles
{
    public class TileFactory : MonoBehaviour
    {
        [SerializeField] private GameObject _tilePrefab;

        private ContainerInstantiator _instantiator;
        private GameplayRules _rules;

        [Inject]
        private void Construct(ContainerInstantiator instantiator, GameplayRules rules)
        {
            _instantiator = instantiator;
            _rules = rules;
        }
        
        public void SpawnTile(TileType type, Vector3 position)
        {
            position = position.SnapToGrid(Vector3.one * _rules.GridSize).WithY(0);
            Tile tile = _instantiator.Instantiate<Tile>(_tilePrefab, position);
            tile.Init(type);
            Instantiate(type.View, tile.Transform);
        }
    }
}