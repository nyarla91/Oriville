using Extentions.Pause;
using Gameplay;
using Gameplay.Highscore;
using GameStates;
using Input;
using PlayerSettings;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private SceneLoader _sceneLoader;
        [SerializeField] private Settings _settings;
        
        public override void InstallBindings()
        {
            Container.Bind<InputDeviceWatcher>().AsSingle();
            
            Container.Bind<SceneLoader>().FromInstance(_sceneLoader).AsSingle();
            
            Container.Bind<Settings>().FromInstance(_settings).AsSingle();
            Container.Bind<ISettingSet>().FromInstance(_settings).AsSingle();
            Container.Bind<ISettingsRead>().FromInstance(_settings).AsSingle();
            
            Pause pause = new Pause();
            Container.Bind<Pause>().FromInstance(pause).AsSingle();
            Container.Bind<IPauseSet>().FromInstance(pause).AsSingle();
            Container.Bind<IPauseRead>().FromInstance(pause).AsSingle();

            Highscore highscore = new Highscore();
            Container.Bind<IHighscoreRead>().FromInstance(highscore).AsSingle();
            Container.Bind<IHighscoreSet>().FromInstance(highscore).AsSingle();
        }
    }
}