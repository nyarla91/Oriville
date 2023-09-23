using System.Linq;
using Extentions;
using UnityEngine;
using Zenject;

namespace Gameplay.Tiles
{
    public class SquareEntity : Transformable
    {
        private float GridSize => GameplayRules.GridSize; 
        
        [Inject] private GameplayRules GameplayRules { get; }

        protected Tile GetAdjacentTileInDirection(Vector3 direction)
        {
            Collider[] overlap = Physics.OverlapSphere(GetAdjacentSquareInDirection(direction), GridSize / 2);
            Tile[] tiles = overlap.Select(collider => collider.GetComponent<Tile>()).Where(tile => tile != null).ToArray();
            return tiles.Length == 0 ? null : tiles[0];
        }

        protected Vector3 GetAdjacentSquareInDirection(Vector3 direction) =>
            Transform.position + direction.WithY(0).normalized * GridSize;
    }
}