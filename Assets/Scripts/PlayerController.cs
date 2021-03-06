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
    public bool gameOver = false;

    public bool isOnGround = true;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //store a reference to the rigidbody omponent
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
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
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 2.0f);
        }
        if(dirtParticle.isStopped)
        {
            Debug.Log("Particle State Stopped?:");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //when it collides with something presumably the ground, set the boolean var to true again
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            isOnGround = false;
            gameOver = true;
            Debug.Log("Game Over!");
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 2.0f);
        }
    }
}
