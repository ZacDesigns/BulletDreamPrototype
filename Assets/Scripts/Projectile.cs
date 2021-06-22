using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Variable References
    public float projSpeed;
    public float lifeTime;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * projSpeed * Time.deltaTime);
    }

    //When the object the script is attached to enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        //If the object collides with object containing tag of Enemy, destroy projectile object
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        //If the object collides with object containing tag of Wall, destroy projectile object
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }


}
