using Gameplay.Tiles;
using UnityEngine;
using Zenject;

namespace Gameplay.States
{
    public class GameplayStateTransitioner : IGameplayStates, IGoToTilePlacementState
    {
        private GameplayState _currentState;

        public TilePlacementState TilePlacement { get; private set; }

        [Inject]
        private void Construct(TileProvider tileProvider)
        {
            Debug.Log(tileProvider);
            TilePlacement = new(tileProvider);
            GoToState(TilePlacement);
        }

        public void GoToTilePlacementState() => GoToState(TilePlacement);

        private void GoToState(GameplayState targetState)
        {
            _currentState?.Exit();
            _currentState = targetState;
            _currentState.Enter();
        }
    }
}
