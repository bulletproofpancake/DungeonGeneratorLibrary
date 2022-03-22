using UnityEngine;

namespace DungeonGeneratorLibrary.SunnyValleyStudio
{
    public class PlayerMovement : MonoBehaviour
    {
        private float moveSpeed = 5f;

        // Update is called once per frame
        private void Update()
        {
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed * Time.deltaTime;
        }
    }
}
