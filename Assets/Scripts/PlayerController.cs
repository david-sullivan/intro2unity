using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //use the new input system

// using physics (gravity and addforce) to move the player

public class PlayerController : MonoBehaviour
{
    //private since no other script needs to use this
    private Rigidbody playerRb;
    //public exposes these variables in the editor under the script's component
    public float jumpForce;
    public float gravityModifier;

    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        //store a reference to the rigidbody omponent
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if space key was pressed
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isOnGround)
        {
            //add an up force to jump
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //since it is jumping, set the boolean var to false
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //when it collides with something presumably the ground, set the boolean var to true again
        isOnGround = true;
    }
}
