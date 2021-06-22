using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Variable, Component and Game Object References
    public GameObject enemyToSpawn;
    public float spawnRate;
    private float timePassed;
    private bool canSpawn;
    private BoxCollider spawnBounds;

    // Start is called before the first frame update
    void Start()
    {
        //Sets boolean canSpawn to true, gets component of type Box Collider
        canSpawn = true;
        spawnBounds = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the bool canSpawn is true, and gameIsOver from script GameManager is not true, this function runs
        if (canSpawn && !GameManager.gameIsOver)
        {
            SpawnEnemy();
            canSpawn = false;
            timePassed = 0.0f;
        }
        //timePassed variable is added to by the function Time.deltaTime for cooldown
        timePassed += Time.deltaTime;

        //If the variable timePassed is greater than or equal to spawnRate, then Can spawn is set as true
        if (timePassed >= spawnRate)
            canSpawn = true;
    }

    //This function controls the random spawning locations of the enemies and places them within an area inside the enemy spawner trigger object
    private void SpawnEnemy()
    {
        float xPos = Random.Range((spawnBounds.size.x * -0.5f), (spawnBounds.size.x * 0.5f)) + spawnBounds.gameObject.transform.position.x;
        float zPos = Random.Range((spawnBounds.size.z * -0.5f), (spawnBounds.size.z * 0.5f)) + spawnBounds.gameObject.transform.position.z;

        Vector3 spawnPos = new Vector3(xPos, 0.0f, zPos);

        Quaternion spawnRot = new Quaternion();
        float rotationAngle = Random.Range(0.0f, 360.0f);
        spawnRot = Quaternion.Euler(0f, rotationAngle, 0f);

        Instantiate(enemyToSpawn, spawnPos, spawnRot);


    }
}