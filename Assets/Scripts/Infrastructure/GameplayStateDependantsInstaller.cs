using Gameplay;
using Gameplay.Tiles;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class GameplayStateDependantsInstaller : MonoInstaller
    {
        [SerializeField] private TileProvider _tileProvider;
        [SerializeField] private TileFactory _tileFactory;
        [SerializeField] private GameplayRules _gameplayRules;
        
        public override void InstallBindings()
        {
            Container.Bind<TileProvider>().FromInstance(_tileProvider).AsSingle();
            Container.Bind<TileFactory>().FromInstance(_tileFactory).AsSingle();
            Container.Bind<GameplayRules>().FromInstance(_gameplayRules).AsSingle();
        }
    }
}