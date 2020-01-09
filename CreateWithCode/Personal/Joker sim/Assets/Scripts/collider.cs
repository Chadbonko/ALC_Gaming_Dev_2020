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
        //this code makes it so that when the player collides with the battery the battery is destroyed and the bool "hasbattery" is made true.
        if (collider.tag == "battery")
        {
            Destroy(GameObject.Find("battery"));
            hasBattery = true;
        }
        //this code makes it so that when the player collides with the wheel the wheel is destroyed and the bool "haswheel" is made true.
        if (collider.tag == "wheel")
        {
            Destroy(GameObject.Find("wheel"));
            hasWheel = true;
        }
        //this code makes it so that when the player collides with the trash can the trash can is destroyed and the bool "emptiedtrash" is made true.
        if (collider.tag == "trash")
        {
            Destroy(GameObject.Find("trash"));
            emptiedTrash = true;
        }
        //this code makes it so that when the player collides with the roomba and all 3 required bools are true the roomba is destroyed and the player recieves a "you win!" message
        if (collider.tag == "roomba" && hasWheel && hasBattery && emptiedTrash)
        {
            Destroy(GameObject.Find("roomba"));
            Debug.Log("You Win!");
            fixRoomba = true;
        }
        //this code makes it so if the player falls on the lawn they die and get game over message. 
        if (collider.tag == "Death")
        {
            Destroy(GameObject.Find("Player"));
            Debug.Log("You an unepic gamer go back and try again.");
        }
    }
}

    
    


