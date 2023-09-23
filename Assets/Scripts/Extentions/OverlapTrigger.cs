﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extentions
{
    public class OverlapTrigger : Transformable
    {
        [SerializeField] private List<Collider> _colliders = new List<Collider>();

        public event Action<Collider> Enter;
        public event Action<Collider> Exit;
        
        public Collider[] Content => _colliders.Where(collider => collider is not null).ToArray();

        public T[] GetContent<T>() where T : Component => Content.Select(collider => collider.GetComponent<T>()).Where(t => t is not null).ToArray();

        public T[] GetContent<T>(LayerMask layerMask) where T : Component
            => GetContent<T>().Where(c => layerMask == (layerMask | (1 << c.gameObject.layer)) && c.gameObject.activeInHierarchy).ToArray();

        private void OnTriggerEnter(Collider other)
        {
            if (_colliders.Contains(other))
                return;
            _colliders.Add(other);
            Enter?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            if (!_colliders.Contains(other))
                return;
            _colliders.Remove(other);
            Exit?.Invoke(other);
        }
    }
}