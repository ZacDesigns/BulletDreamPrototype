using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    //Variable References
    private PauseMenuController pauseControl;

    // Start is called before the first frame update
    void Start()
    {
        pauseControl = GameObject.Find("Canvas").GetComponent<PauseMenuController>();
    }

    //Resumes the game when the function is ran
    public void buttonResume()
    {
        pauseControl.pauseScreen.SetActive(false);
        PauseMenuController.isPaused = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
