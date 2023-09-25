using System.Collections;
using Gameplay.Score;
using GameStates;
using TMPro;
using UI;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private ScoreCounter _scoreCounter;
        [SerializeField] private Menu _menu;
        [SerializeField] private float _openDelay;
        [SerializeField] private TMP_Text _finalScoreCorunter;

        [Inject] private SceneLoader SceneLoader { get; }
        [Inject] private Highscore Highscore { get; }

        public void Show() => StartCoroutine(ShowWithDelay());
        
        private IEnumerator ShowWithDelay()
        {
            Highscore.Add(_scoreCounter.Current);
            _finalScoreCorunter.text = _scoreCounter.Current.ToString();
            yield return new WaitForSeconds(_openDelay);
            _menu.Open();
        }

        public void Restart() => SceneLoader.LoadGameplay();

        public void ReturnToMainMenu() => SceneLoader.LoadMainMenu();
    }
}