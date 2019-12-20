using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12; private float maxSpeed = 16;
    private float maxTorque = 10; private float xRange = 4;
    private float ySpawnPos = -6;
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem explosionParticle;
    // Start is called before the first frame update This code provides a random spawn position for our objects.
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        transform.position = (RandomSpawnPos());
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    //This code defines our force, torque, and position used above randomizing the speed and position and heigth reached and velocity our objects are launched with.
    Vector3 RandomForce() { return Vector3.up * Random.Range(minSpeed, maxSpeed); }
    float RandomTorque() { return Random.Range(-maxTorque, maxTorque); }
    Vector3 RandomSpawnPos() { return new Vector3(Random.Range(-xRange, xRange), ySpawnPos); }
    //This code makes it so when the player clicks an object it explodes and makes a particle effect and it also alters the score according to the object's point value.
    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }
    }
    //This code destroys objects that pass through the sensor at the bottom of the play area. It also compares tags allowing "bad" objects to pass through and ending the game if a good object falls through.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }
}