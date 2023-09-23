using UnityEngine;

namespace Extentions.Pause
{
    public interface IPauseSet
    {
        void AddPauseSource(MonoBehaviour source);
        void RemovePauseSource(MonoBehaviour source);
    }
}