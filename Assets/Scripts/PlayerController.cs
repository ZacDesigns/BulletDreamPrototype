using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigBod;

    [HideInInspector]
    public bool isDead;


    public float moveSpeed = 6;
    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
        isDead = false;

    }

    void Update()
    {
        //inputs
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //movement
        Vector3 movePos = transform.right * x + transform.forward * y;
        Vector3 newMovePos = new Vector3(movePos.x, rigBod.velocity.y, movePos.z);

        rigBod.velocity = newMovePos;



    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Player Dead!!");

        }
    }






}
