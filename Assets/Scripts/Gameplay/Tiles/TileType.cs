using System;
using Gameplay.Tiles.Rules;
using UnityEditor;
using UnityEngine;

namespace Gameplay.Tiles
{
    [CreateAssetMenu(menuName = "Tile Type", order = 0)]
    public class TileType : ScriptableObject
    {
        [SerializeField] private TileRule _rule;
        [SerializeField] private TileBiome _biome;
        [SerializeField] private GameObject _view;

        public TileRule Rule => _rule;
        public TileBiome Biome => _biome;
        public GameObject View => _view;
    }

    public enum TileBiome
    {
        None,
        Forest,
        Sea,
        Town,
    }
}