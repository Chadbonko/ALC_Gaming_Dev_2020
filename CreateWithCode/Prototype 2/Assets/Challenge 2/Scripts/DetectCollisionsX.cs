using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    //When balls and dogs collide destroy ballss
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
