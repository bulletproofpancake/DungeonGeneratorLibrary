using UnityEngine;

namespace DungeonGeneratorLibrary.SunnyValleyStudio.Data
{
    [CreateAssetMenu(fileName = "SimpleRandomWalkParameters_",menuName = "PCG/SimpleRandomWalkData")]
    public class SimpleRandomWalkData : ScriptableObject
    {
        public int iterations = 10, walkLength = 10;
        public bool startRandomlyEachIteration = true;
    }
}
