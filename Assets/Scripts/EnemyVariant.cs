using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyVariant : MonoBehaviour
{
    //Variable, Component and Game Object References
    public AudioSource EnemyDie;
    public float speed;
    public float playerDetected = 12;
    public GameObject player;
    private NavMeshAgent navAgent;

    //Audio functions
    public void PlayEnemyDie()
    {
        EnemyDie.Play();
    }


    // Start is called before the first frame update
    void Start()
    {
        //finds Game Object with the tag Player and assigns it to player variable, gets NavMeshComponent and assigns it to navAgent variable
        player = GameObject.FindGameObjectWithTag("Player");
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //If gameIsOver is equal to false, then the function will run
        if (GameManager.gameIsOver == false)
        {
            //If the transform position and player transform position are less than the playerDetected radius, set player as target destination
            if (Vector3.Distance(transform.position, player.transform.position) < playerDetected)
            {
                navAgent.destination = player.transform.position;
            }
        }
    }

    //When the object the script is attached to enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        //If the object collides with object containing tag of Player Projectile, run kill function
        if (other.tag == "Player Projectile" && GameManager.gameIsOver == false)
        {
            Kill();
        }
    }
    //Kill function which destroys the game object and adds 5 points to the variable scoreVal from the Score script
    public void Kill()
    {
        PlayEnemyDie();
        Destroy(gameObject);
        Score.scoreVal += 5;
    }
}
