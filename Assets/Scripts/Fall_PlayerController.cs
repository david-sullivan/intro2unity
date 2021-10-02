using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fall_PlayerController : MonoBehaviour
{
    //public InputAction HorizontalAction = inputMap.AddAction("Horizontal");
    [SerializeField]
    private float speed = 10.0f;
    private float xRange = 8;
    //private PlayerActions playerActions;
    //private Vector2 moveInput;
    //private Vector3 _direction;
    public Rigidbody rb;
    public float jumpForce = 10f;
    private float movementX; // left/right
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movementX * speed * Time.deltaTime, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movementX = ctx.ReadValue<Vector2>().x;
    }

    private void OnEnable()
    {
        //playerActions.PlayerMap.Enable();
    }

    private void OnDisable()
    {
        //playerActions.PlayerMap.Disable();
    }
}
