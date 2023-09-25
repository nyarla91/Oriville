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
        protected float GridSize => GameplayRules.GridSize;

        protected IEnumerable<Tile> AdjacentTiles => FourDirections.Select(GetSquareEntityInDirection<Tile>).ToArray();
        protected Vector3[] FourDirections => new []{Vector3.forward, Vector3.back, Vector3.left, Vector3.right};

        [Inject] private GameplayRules GameplayRules { get; }

        protected TEntity GetSquareEntityInDirection<TEntity>(Vector3 direction) where TEntity : SquareEntity
        {
            Collider[] overlap = Physics.OverlapSphere(GetAdjacentSquareInDirection(direction), GridSize / 2);
            TEntity[] tiles = overlap.Select(collider => collider.GetComponent<TEntity>()).Where(tile => tile != null).ToArray();
            return tiles.Length == 0 ? null : tiles[0];
        }

        protected Vector3 GetAdjacentSquareInDirection(Vector3 direction) =>
            Transform.position + direction.WithY(0).normalized * GridSize;

        protected void ForeachAdjacentEntity<TEntity>(Action<Vector3, TEntity> predicate) where TEntity : SquareEntity
        {
            foreach (Vector3 direction in FourDirections)
            {
                TEntity tile = GetSquareEntityInDirection<TEntity>(direction);
                if (tile != null && tile.Equals(this))
                    continue;
                predicate.Invoke(direction, tile);
            }
        }
    }
}