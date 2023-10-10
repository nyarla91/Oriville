using Gameplay;
using Gameplay.Score;
using Gameplay.Tiles;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class GameplayStateDependantsInstaller : MonoInstaller
    {
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private GameplayRules _gameplayRules;
        [SerializeField] private TileFactory _tileFactory;
        
        public override void InstallBindings()
        {
            GameplayActions actions = new GameplayActions();
            actions.Enable();
            Container.Bind<GameplayActions>().FromInstance(actions);
            
            Container.Bind<Camera>().FromInstance(_mainCamera).AsSingle();
            Container.Bind<GameplayRules>().FromInstance(_gameplayRules).AsSingle();
            Container.Bind<TileFactory>().FromInstance(_tileFactory).AsSingle();

            TileProvider tileProvider = Container.Instantiate<TileProvider>();
            Container.Bind<TileProvider>().FromInstance(tileProvider).AsSingle();
            
            Container.Bind<ScoreCounter>().AsSingle();
            
            tileProvider.SpawnFirstTile();
        }
    }
}