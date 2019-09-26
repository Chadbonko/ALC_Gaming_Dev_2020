using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinpropeller : MonoBehaviour
{
    private float turnspeed = 2000f;

    // Update is called once per frame
    void Update()
    {
        //We Will make the propeller rotate
        transform.Rotate(Vector3.forward * turnspeed * Time.deltaTime);
    }
}
