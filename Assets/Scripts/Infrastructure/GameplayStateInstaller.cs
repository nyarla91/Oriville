using Gameplay.States;
using Zenject;

namespace Infrastructure
{
    public class GameplayStateInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GameplayStateTransitioner transitioner = Container.Instantiate<GameplayStateTransitioner>();
            Container.Bind<IGameplayStates>().FromInstance(transitioner).AsSingle();
            Container.Bind<IGoToTilePlacementState>().FromInstance(transitioner).AsSingle();
        }
    }
}