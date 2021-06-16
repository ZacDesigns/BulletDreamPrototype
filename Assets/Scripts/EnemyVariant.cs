﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyVariant : MonoBehaviour
{
    public float speed;

    public float playerDetected = 12;
    public GameObject player;
    private NavMeshAgent navAgent;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        navAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < playerDetected)
        {
            navAgent.destination = player.transform.position;
        }
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Dead!!");
            other.gameObject.GetComponent<PlayerController>().isDead = true;

        }
        if (other.tag == "Player Projectile")
        {
            Kill();
        }
    }



    public void Kill()
    {
        Destroy(gameObject);
    }


}
