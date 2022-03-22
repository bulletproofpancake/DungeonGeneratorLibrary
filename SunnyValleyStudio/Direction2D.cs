﻿using System.Collections.Generic;
using UnityEngine;

namespace DungeonGeneratorLibrary.SunnyValleyStudio
{
    public static class Direction2D
    {
        public static List<Vector2Int> cardinalDirectionsList = new List<Vector2Int>
        {
            new Vector2Int(0, 1), // UP
            new Vector2Int(1, 0), // RIGHT
            new Vector2Int(0, -1), // DOWN
            new Vector2Int(-1, 0) // LEFT
        };

        public static Vector2Int GetRandomCardinalDirection()
        {
            return cardinalDirectionsList[Random.Range(0, cardinalDirectionsList.Count)];
        }
    }
}