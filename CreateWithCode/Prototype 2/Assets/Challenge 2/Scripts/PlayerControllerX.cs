using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //These private floats are the fire rate and a buffer between firing so that the player cannot spam.
    private float dogRate = 0.75f;
    private float nextDog = 0.75f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog only allow player to send dog every 0.75 seconds
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextDog = Time.time + dogRate;
        }
    }
}