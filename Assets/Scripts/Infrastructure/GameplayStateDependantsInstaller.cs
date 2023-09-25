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
        [SerializeField] private TileProvider _tileProvider;
        [SerializeField] private ScoreCounter _scoreCounter;
        
        public override void InstallBindings()
        {
            GameplayActions actions = new GameplayActions();
            actions.Enable();
            Container.Bind<GameplayActions>().FromInstance(actions);
            
            Container.Bind<Camera>().FromInstance(_mainCamera).AsSingle();
            Container.Bind<GameplayRules>().FromInstance(_gameplayRules).AsSingle();
            Container.Bind<TileProvider>().FromInstance(_tileProvider).AsSingle();
            Container.Bind<ScoreCounter>().FromInstance(_scoreCounter).AsSingle();
            
        }
    }
}