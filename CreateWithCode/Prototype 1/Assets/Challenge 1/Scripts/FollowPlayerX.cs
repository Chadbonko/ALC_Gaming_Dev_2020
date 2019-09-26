using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        //we will make the camera follow the player from a set view
        transform.position = plane.transform.position + offset;
    }
}
