using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable and Component References
    private Rigidbody rigBod;
    [HideInInspector]
    public bool isDead;
    public GameManager gameManager;
    public float moveSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        //Getting components and setting variable values on game start
        rigBod = GetComponent<Rigidbody>();
        isDead = false;

    }

    // Update is called once per frame
    void Update()
    {
        //If the player is not in a dead state, the player is able to move around
        if (!transform.root.GetComponent<PlayerController>().isDead)
        {
            //inputs
            float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
            float y = Input.GetAxisRaw("Vertical") * moveSpeed;

            //movement
            Vector3 movePos = transform.right * x + transform.forward * y;
            Vector3 newMovePos = new Vector3(movePos.x, rigBod.velocity.y, movePos.z);

            rigBod.velocity = newMovePos;
        }
    }

    //When the object the script is attached to enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        //Checks if player has touched enemy, if they have the player dies
        if (other.tag == "Enemy")
        {
            FindObjectOfType<GameManager>().GameOver();
            isDead = true;
        }

    }






}
