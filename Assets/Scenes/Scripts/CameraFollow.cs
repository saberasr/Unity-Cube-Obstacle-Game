using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;        // Player's transform
    public Vector3 offset;          // Offset from the player

    void Update()
    {
        // Update camera's position based on player's position and the offset
        transform.position = player.position + offset;
    }
}
