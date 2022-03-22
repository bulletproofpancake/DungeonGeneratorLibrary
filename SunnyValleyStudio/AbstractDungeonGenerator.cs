﻿using UnityEngine;

namespace DungeonGeneratorLibrary.SunnyValleyStudio
{
    public abstract class AbstractDungeonGenerator : MonoBehaviour
    {
        [SerializeField]
        protected TilemapVisualizer tilemapVisualizer = null;
        [SerializeField]
        protected Vector2Int startPosition = Vector2Int.zero;

        public void GenerateDungeon()
        {
            tilemapVisualizer.Clear();
            RunProceduralGeneration();
        }

        public void ClearTilemap()
        {
            tilemapVisualizer.Clear();
        }

        protected abstract void RunProceduralGeneration();
    }
}