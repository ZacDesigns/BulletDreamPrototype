using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //Variable and Component References
    private PauseMenuController pauseController;
    private PlayerController playerController;
    public float mouseSensitivity = 10f;
    public Transform player;
    private float x = 0;
    private float y = 0;


    // Start is called before the first frame update
    void Start()
    {
        //Finding game object called Canvas
        pauseController = GameObject.Find("Canvas").GetComponent<PauseMenuController>();

        //Remove cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Finding game object called Player
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //Checks if the game is not paused and the player is not dead, then runs the function
       if (!PauseMenuController.isPaused && !GameManager.gameIsOver)
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
