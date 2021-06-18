using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    private PauseMenuController pauseControl;

    void Start()
    {
        pauseControl = GameObject.Find("Canvas").GetComponent<PauseMenuController>();
    }


    public void buttonResume()
    {
        pauseControl.pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        pauseControl.isPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }






    void Update()
    {
        
    }



}
