using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    //Variable and Game Object References
    private AudioSource Weapon;
    public GameObject projectileObject;
    public float rateOfFire;
    private float timePassed;
    private bool ableShoot;


    // Start is called before the first frame update
    void Start()
    {
        //ableShoot variable is set to true, timePassed is set to 0
        ableShoot = true;
        timePassed = 0.0f;
        Weapon = GameObject.Find("Weapon").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the left mouse button is clicked, the variable ableShoot is equal to true and isPaused from other script is not true, run function
        if (Input.GetMouseButtonDown(0) && ableShoot == true && !PauseMenuController.isPaused)
        {
            Shoot();
            ableShoot = false;
            timePassed = 0.0f;
        }
        //timePassed variable is added to by the function Time.deltaTime for cooldown
        timePassed += Time.deltaTime;

        //If the timePassed variable is greater than or equal to the variable rateOfFire, then run the function
        if (timePassed >= rateOfFire)
        {
            ableShoot = true;
        }

    }

    //A function called Shoot that can only be accessed within this script
    private void Shoot()
    {
        //If the PlayerController variable isDead is not true, then run function
        if (!transform.root.GetComponent<PlayerController>().isDead)
        {
            //Instantiate Projectile Game Object and make it move forward
            Instantiate(projectileObject, transform.position, transform.rotation);
            Weapon.PlayOneShot(Weapon.clip);
        }
    }



}
