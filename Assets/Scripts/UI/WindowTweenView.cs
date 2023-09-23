using Extentions;
using UnityEngine;

namespace UI
{
    public class WindowTweenView : RectTransformable
    {
        [SerializeField] private CanvasGroup _canvasGroup;
        
        public void OnOpen()
        {
            RectTransform.DOAppear(_canvasGroup);
        }

        public void OnClose()
        {
            RectTransform.DODisappear(_canvasGroup);
        }
    }
}