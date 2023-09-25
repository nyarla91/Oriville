using Extentions.Pause;
using Gameplay.Tiles;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class GameOverDetector : MonoBehaviour
    {
        [SerializeField] private AudioSource _sound;
        [SerializeField] private TileProvider _tileProvider;
        [SerializeField] private BoardBounds _boardBounds;
        [SerializeField] private GameOverScreen _screen;

        [Inject] private IPauseSet PauseSet { get; }
        
        private void Start()
        {
            _tileProvider.TilePlaced += CheckGameForOver;
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
            _screen.Show();
        }
    }
}