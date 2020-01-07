using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public bool hasBattery;
    public bool hasWheel;
    public bool emptiedTrash;
    public bool fixRoomba;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        hasBattery = false;
        hasWheel = false;
        emptiedTrash = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "battery")
        {
            Destroy(GameObject.Find("battery"));
            hasBattery = true;
        }
        if(collider.tag == "wheel")
        {
            Destroy(GameObject.Find("wheel"));
            hasWheel = true;
        }
        if(collider.tag == "trash")
        {
            Destroy(GameObject.Find("trash"));
            emptiedTrash = true;
        }
        if (collider.tag == "roomba" && hasWheel && hasBattery && emptiedTrash)
        {
            Destroy(GameObject.Find("roomba"));
            Debug.Log("You Win!");
        }
    }
}

    
    


