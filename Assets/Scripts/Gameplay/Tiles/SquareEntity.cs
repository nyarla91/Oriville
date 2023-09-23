using System;
using System.Collections.Generic;
using System.Linq;
using Extentions;
using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace Gameplay.Tiles
{
    public class SquareEntity : Transformable
    {
        private float GridSize => GameplayRules.GridSize;

        protected IEnumerable<Tile> AdjacentTiles => FourDirections.Select(GetAdjacentTileInDirection).ToArray();
        protected Vector3[] FourDirections => new []{Vector3.forward, Vector3.back, Vector3.left, Vector3.right};

        [Inject] private GameplayRules GameplayRules { get; }

        protected Tile GetAdjacentTileInDirection(Vector3 direction)
        {
            Collider[] overlap = Physics.OverlapSphere(GetAdjacentSquareInDirection(direction), GridSize / 2);
            Tile[] tiles = overlap.Select(collider => collider.GetComponent<Tile>()).Where(tile => tile != null).ToArray();
            return tiles.Length == 0 ? null : tiles[0];
        }

        protected Vector3 GetAdjacentSquareInDirection(Vector3 direction) =>
            Transform.position + direction.WithY(0).normalized * GridSize;

        protected void ForeachAdjacentTile(Action<Vector3, Tile> predicate)
        {
            foreach (Vector3 direction in FourDirections)
            {
                Tile tile = GetAdjacentTileInDirection(direction);
                predicate.Invoke(direction, tile);
            }
        }
    }
}