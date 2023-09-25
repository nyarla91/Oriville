using DG.Tweening;
using Extentions;
using UnityEngine;

namespace Gameplay.Tiles
{
    public class TileView : Transformable
    {
        [SerializeField] private Transform _placementModel;
        [SerializeField] private Transform _finalModel;
        [SerializeField] private float _placementHeight;
        [SerializeField] private float _placeJumpHeight;
        [SerializeField] private float _placeDuration;

        public void Init(Tile model)
        {
            Vector3 modelPosition = new Vector3(0, _placementHeight, 0);
            _placementModel.gameObject.SetActive(true);
            _finalModel.gameObject.SetActive(false);
            _placementModel.localPosition = modelPosition;
            _finalModel.localPosition = modelPosition;
            model.Placed += PlayPlaceAnimation;
        }

        private void PlayPlaceAnimation()
        {
            _placementModel.gameObject.SetActive(false);
            _finalModel.gameObject.SetActive(true);
            _finalModel.DOLocalMoveY(_placementHeight + _placeJumpHeight, _placeDuration).onComplete += () =>
            {
                _finalModel.DOLocalMoveY(0, _placeDuration);
            };
        }
    }
}