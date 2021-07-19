using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSoundManager : MonoBehaviour
{
    //Variable and Game Object References
    public AudioSource ShootSound;

    //Audio functions
    public void PlayShootSound()
    {
        ShootSound.Play();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
