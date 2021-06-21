﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float spawnRate;

    private float timePassed;
    private bool canSpawn;
    private BoxCollider spawnBounds;

    void Start()
    {
        canSpawn = true;
        spawnBounds = GetComponent<BoxCollider>();
    }


    void Update()
    {
        if (canSpawn && !GameManager.gameIsOver)
        {
            SpawnEnemy();
            canSpawn = false;
            timePassed = 0.0f;
        }

        timePassed += Time.deltaTime;

        if (timePassed >= spawnRate)
            canSpawn = true;
    }
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