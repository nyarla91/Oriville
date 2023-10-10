using Gameplay;
using Gameplay.Highscore;
using TMPro;
using UnityEngine;
using Zenject;

namespace MainMenu
{
    public class HighscoreValue : MonoBehaviour
    {
        [SerializeField]  private TMP_Text _counter;

        [Inject]
        private void Construct(IHighscoreRead highscore)
        {
            _counter.text = highscore.Current.ToString();
        }
    }
}