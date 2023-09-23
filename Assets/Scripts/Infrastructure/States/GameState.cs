using System.Collections;

namespace Infrastructure.States
{
    public abstract class GameState
    {
        public abstract IEnumerator Enter();
        public abstract IEnumerator Exit();
    }
}