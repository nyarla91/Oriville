using Extentions.Pause;
using Gameplay.Highscore;
using Gameplay.Score;
using Gameplay.Tiles;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class GameOverDetector : MonoBehaviour
    {
        [SerializeField] private AudioSource _sound;
        [SerializeField] private BoardBounds _boardBounds;
        [SerializeField] private GameOverScreen _screen;

        [Inject] private ScoreCounter ScoreCounter { get; }
        [Inject] private TileProvider TileProvider { get; }
        [Inject] private IHighscoreSet Highscore { get; }
        [Inject] private IPauseSet PauseSet { get; }
        
        private void Start()
        {
            TileProvider.TilePlaced += CheckGameForOver;
        }

        private void CheckGameForOver(Tile[] tiles)
        {
            if (tiles.Length >= _boardBounds.SquaresInBounds)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            _sound.Play();
            PauseSet.AddPauseSource(this);
            Highscore.Add(ScoreCounter.Current);
            _screen.Show();
        }
    }
}