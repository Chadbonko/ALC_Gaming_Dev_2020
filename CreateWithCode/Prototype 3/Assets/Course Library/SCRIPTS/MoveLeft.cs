using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    private float leftBound = -15;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
            GameObject.Find("Player").GetComponent<PlayerController>(); 
    }
    // This code moves the obstacles and background left to create an illusion of the player running endlessly and stops them on game over. We use an if statement so if game over is false the script moves left. 
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        // This if statement compares tags to destroy obstacle once it reaches leftbound
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) { Destroy(gameObject); }
    }
}
