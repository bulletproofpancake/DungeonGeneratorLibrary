using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace DungeonGeneratorLibrary.SunnyValleyStudio
{
    public class TilemapVisualizer : MonoBehaviour
    {
        [SerializeField]
        private Tilemap floorTilemap, wallTilemap;
    
        [SerializeField]
        private TileBase[] floorTiles, wallTop;

        public void PaintFloorTiles(IEnumerable<Vector2Int> floorPositions)
        {
            PaintTiles(floorPositions, floorTilemap, floorTiles);
        }

        private void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase[] tiles)
        {
            foreach (var position in positions)
            {
                PaintSingleTile(tilemap, tiles[Random.Range(0, tiles.Length)], position);
            }
        }

        private void PaintSingleTile(Tilemap tilemap, TileBase tile, Vector2Int position)
        {
            var tilePosition = tilemap.WorldToCell((Vector3Int) position);
            tilemap.SetTile(tilePosition, tile);
        }
    
        public void Clear()
        {
            floorTilemap.ClearAllTiles();
            wallTilemap.ClearAllTiles();
        }

        public void PaintSingleBasicWall(Vector2Int position)
        {
            PaintSingleTile(wallTilemap, wallTop[Random.Range(0, wallTop.Length)], position);
        }
    }
}
