using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public GameObject projectileObject;

    public float rateOfFire;
    private float timePassed;
    private bool ableShoot;


    private void Start()
    {
        ableShoot = true;
        timePassed = 0.0f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ableShoot == true)
        {
            Shoot();
            ableShoot = false;
            timePassed = 0.0f;
        }

        timePassed += Time.deltaTime;

        if (timePassed >= rateOfFire)
        {
            ableShoot = true;
        }

    }

    private void Shoot()
    {
        if (!transform.root.GetComponent<PlayerController>().isDead)
        {
            Instantiate(projectileObject, transform.position, transform.rotation);
        }
    }



}
