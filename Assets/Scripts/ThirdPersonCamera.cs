using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("References")]
    public Transform Orientation;
    public Transform Player;
    public Transform PlayerObject;
    public Rigidbody rb;

    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewDir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        Orientation.forward = viewDir.normalized;

        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = Orientation.forward * VerticalInput + Orientation.right * HorizontalInput;

        if(inputDir != Vector3.zero)
        {
            PlayerObject.forward = Vector3.Slerp(PlayerObject.forward, inputDir.normalized, Time.deltaTime * RotationSpeed);
        }
    }
}
