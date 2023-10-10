using UnityEngine;

namespace Gameplay.Highscore
{
    public class Highscore : IHighscoreSet, IHighscoreRead
    {
        public int Current { get; private set; }

        public void Add(int score)
        {
            if (score <= Current)
                return;
            Current = score;
            PlayerPrefs.SetInt("hs", Current);
            PlayerPrefs.Save();
        }
        
        public Highscore()
        {
            Current = PlayerPrefs.GetInt("hs");
        }
    }
}