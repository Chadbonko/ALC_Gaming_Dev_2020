using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyoutofbounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Update is called once per frame
    void Update()
    {
        // Give player game over message if an animal goes out of bounds, also destroys any npc that gets out of bounds.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
