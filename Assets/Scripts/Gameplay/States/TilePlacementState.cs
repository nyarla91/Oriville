using Gameplay.Tiles;
using UnityEngine;

namespace Gameplay.States
{
    public class TilePlacementState : GameplayState
    {
        private TileProvider Provider { get; set; }

        public TilePlacementState(TileProvider provider)
        {
            Provider = provider;
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }
    }
}