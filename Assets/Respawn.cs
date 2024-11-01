using UnityEngine;
using Cinemachine;
using System.Collections;

public class RE : MonoBehaviour
{
    public Transform respawnPoint;
    public CinemachineFreeLook freeLookCamera;
    public Transform Orientation; // Reference to the Orientation object
    public PlayerMovement playerMovement;

    public float desiredHorizontalAngle = 180f;  // Adjust to your preference
    public float desiredVerticalPosition = 0.5f; // Adjust to your preference


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (respawnPoint != null)
            {
                // Move player to the respawn point
                other.transform.position = respawnPoint.position;

                // Reset the FreeLook camera's Follow and LookAt targets
                if (freeLookCamera != null)
                {
                    freeLookCamera.Follow = other.transform;
                    freeLookCamera.LookAt = other.transform;

                    // Set camera orientation
                    freeLookCamera.m_XAxis.Value = desiredHorizontalAngle;
                    freeLookCamera.m_YAxis.Value = desiredVerticalPosition;

                    // Force the Cinemachine FreeLook camera to refresh
                    freeLookCamera.OnTargetObjectWarped(other.transform, respawnPoint.position - other.transform.position);
                }
                playerMovement.RealignOrientation();

                // Start a coroutine to re-align Orientation after a brief delay
                StartCoroutine(RealignOrientation());
            }
            else
            {
                Debug.LogError("Respawn point not set!");
            }
        }
    }

    private IEnumerator RealignOrientation()
    {
        // Wait a frame to ensure Cinemachine has fully updated
        yield return null;

        // Align Orientation to the camera's horizontal direction
        if (Orientation != null && Camera.main != null)
        {
            Orientation.forward = new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z).normalized;
            Debug.Log("Orientation re-aligned with camera direction.");
        }
    }
}
