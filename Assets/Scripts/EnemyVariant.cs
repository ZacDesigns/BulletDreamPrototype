using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVariant : MonoBehaviour
{
    public float speed; 


    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Dead!!");

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
