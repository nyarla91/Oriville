using System;
using UnityEngine;

namespace Gameplay.Tiles
{
    public class EmptySquareView : MonoBehaviour
    {
        [SerializeField] private EmptySquare _model;
        [SerializeField] private GameObject _plane;

        private void Update()
        {
            _plane.SetActive(_model.Active);
        }
    }
}