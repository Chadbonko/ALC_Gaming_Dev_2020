using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 5, -15);

    // Update is called once per frame
    void Update()
    {
        //we will have the camera follow the player
        transform.position = player.transform.position + offset;
    }
}
