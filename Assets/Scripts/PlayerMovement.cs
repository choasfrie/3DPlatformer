using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    [Header("Movement")]
    public float moveSpeed;

    public float GroundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    public int amountOfJumps;
    public int maxJumps = 2;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Groundcheck")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform Orientation;

    float HorizontalInput;
    float VerticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
        readyToJump = true;
        amountOfJumps = maxJumps;
    }


    // Update is called once per frame
    void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();
        SpeedControl();

        if (grounded)
        {
            rb.drag = GroundDrag;
            amountOfJumps = maxJumps; 
            readyToJump = true; 
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(jumpKey) && readyToJump && amountOfJumps > 0)
        {
            if (amountOfJumps == maxJumps)
            {
                Jump();
            }
            else if (amountOfJumps > 0)
            {
                DoubleJump();
            }

            amountOfJumps--; 
            readyToJump = false; 

            Invoke(nameof(ResetJump), jumpCooldown); 
        }
    }

    private void MovePlayer()
    {
        moveDirection = Orientation.forward * VerticalInput + Orientation.right * HorizontalInput;

        // on ground
        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        // in air
        else if (!grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //limits speed so you cant move at the speed of light
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        // Reset vertical velocity before jumping
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        readyToJump = true;
    }

    private void DoubleJump()
    {
        // Reset vertical velocity before double jumping
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    public void RealignOrientation()
    {
        if (Orientation != null && Camera.main != null)
        {
            Orientation.forward = new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z).normalized;
        }
    }

}
