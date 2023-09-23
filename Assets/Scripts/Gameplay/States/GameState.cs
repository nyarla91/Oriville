using System.Threading.Tasks;

namespace Gameplay.States
{
    public abstract class GameplayState
    {
        public abstract void Enter();
        public abstract void Exit();
    }
}