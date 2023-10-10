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
        [SerializeField] private Menu _menu;
        [SerializeField] private float _openDelay;
        [SerializeField] private TMP_Text _finalScoreCorunter;

        [Inject] private ScoreCounter ScoreCounter { get; }
        [Inject] private SceneLoader SceneLoader { get; }

        public void Show() => StartCoroutine(ShowWithDelay());
        
        private IEnumerator ShowWithDelay()
        {
            _finalScoreCorunter.text = ScoreCounter.Current.ToString();
            yield return new WaitForSeconds(_openDelay);
            _menu.Open();
        }

        public void Restart() => SceneLoader.LoadGameplay();

        public void ReturnToMainMenu() => SceneLoader.LoadMainMenu();
    }
}