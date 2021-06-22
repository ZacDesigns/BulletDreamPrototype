using System.Collections;
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
        if (GameManager.gameIsOver == false)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < playerDetected)
            {
                navAgent.destination = player.transform.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player Projectile" && GameManager.gameIsOver == false)
        {
            Kill();
        }
    }
    public void Kill()
    {
        Destroy(gameObject);
        Score.scoreVal += 5;
    }
}
