using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool isOnGround = true;
    public bool gameOver;
    public bool highAsFrick = true;
    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;
    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;
    private float weakFloatForce = 10.0f;
    private float weakerFloatForce = 5.0f;
    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip bounceSound;
    


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game

        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up

        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
            highAsFrick = false;
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
          
        }

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("Sky"))
        {
            highAsFrick = true;
            playerRb.AddForce(Vector3.down * weakerFloatForce, ForceMode.Impulse);
            playerAudio.PlayOneShot(bounceSound, 1.0f);
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            playerRb.AddForce(Vector3.up * weakFloatForce, ForceMode.Impulse);
            playerAudio.PlayOneShot(bounceSound, 1.0f);

        }
    }
}

