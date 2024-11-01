using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab; // Drag the Player prefab here
    public Transform respawnPoint; // Assign the Respawnpoint01 in the Inspector

    private void Start()
    {
        if (respawnPoint == null)
        {
            Debug.LogError("Respawn point not assigned. Please assign a respawn point in the Inspector.");
            return;
        }

        // Spawn the player at the respawn point
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        Debug.Log("Player spawned at Respawnpoint01.");
    }
}
