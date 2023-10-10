using System;
using System.Threading.Tasks;
using Extentions;
using Extentions.Pause;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using Zenject;

namespace Gameplay.Tiles
{
    public class EmptySquare : SquareEntity, IPointerEnterHandler, IPointerExitHandler
    {
        private bool _selected;
        private bool _inBounds;

        public bool Active => _inBounds && TileProvider.PendingTile != null;
        
        [Inject] private IPauseRead PauseRead { get; }
        [Inject] private GameplayActions Actions { get; }
        [Inject] private ContainerInstantiator Instantiator { get; }
        [Inject] private TileProvider TileProvider { get; }

        private void Awake()
        {
            Actions.Placement.Place.started += TryPlace;
        }

        private void TryPlace(InputAction.CallbackContext _)
        {
            if ( ! Active || PauseRead.IsPaused || ! _selected)
                return;
            TileProvider.PlacePendingTile();
            SpawnSquaresAround();
            Destroy(gameObject);
        }

        private void SpawnSquaresAround()
        {
            ForeachAdjacentEntity<SquareEntity>((direction, entity) =>
            {
                if (entity != null)
                    return;
                Vector3 position = GetAdjacentSquareInDirection(direction);
                EmptySquare newSquare = Instantiator.Instantiate<EmptySquare>(gameObject, position);
                newSquare._inBounds = false;
            });
        }

        public async void OnPointerEnter(PointerEventData eventData)
        {
            if ( ! Active || PauseRead.IsPaused)
                return;
            _selected = true;
            TileProvider.ShowPendingTileAtPosition(Transform.position);
            await Task.Delay(50);
            TileProvider.PendingTile.StartPointsPreview();
            ForeachAdjacentEntity<Tile>((_, tile) =>
            {
                if (tile == null)
                    return;
                tile.StartPointsPreview();
            });
        }

        private void Update()
        {
            print(_inBounds);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if ( ! Active || PauseRead.IsPaused)
                return;
            _selected = false;
            TileProvider.HidePendingTile();
            TileProvider.PendingTile.EndPointsPreview();
            ForeachAdjacentEntity<Tile>((_, tile) =>
            {
                if (tile == null)
                    return;
                tile.EndPointsPreview();
            });
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out BoardBounds _))
                _inBounds = true;
        }

        private void OnDestroy()
        {
            Actions.Placement.Place.started -= TryPlace;
        }
    }
}