using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private PauseMenuController pauseController;



    public float mouseSensitivity = 10f;
    public Transform player;
    private float x = 0;
    private float y = 0;


    void Start()
    {
        pauseController = GameObject.Find("Canvas").GetComponent<PauseMenuController>();
        //Remove cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       if (pauseController.isPaused == false)
        {
            //Mouse look 
            x += -Input.GetAxis("Mouse Y") * mouseSensitivity;
            y += Input.GetAxis("Mouse X") * mouseSensitivity;

            //MathfClamp
            x = Mathf.Clamp(x, -90, 90);

            //rotations
            transform.localRotation = Quaternion.Euler(x, 0, 0);
            player.transform.localRotation = Quaternion.Euler(0, y, 0);
        }
    }


}
