using Gameplay;
using TMPro;
using UnityEngine;
using Zenject;

namespace MainMenu
{
    public class HighscoreValue : MonoBehaviour
    {
        [SerializeField]  private TMP_Text _counter;

        [Inject]
        private void Construct(Highscore highscore)
        {
            _counter.text = highscore.Current.ToString();
        }
    }
}