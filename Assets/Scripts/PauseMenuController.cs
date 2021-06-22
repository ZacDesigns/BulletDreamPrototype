using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{    //Variable and Game Object References
    public GameObject pauseScreen;
    public GameManager gameManager;
    public PlayerController playerController;
    [HideInInspector]
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        //If the game isn't in game over state, checks if escape is pressed and if the game is already paused
        if (GameManager.gameIsOver == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }
    //Unpauses the game
    void Resume()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    //Pauses the game
    void Pause()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }





}
