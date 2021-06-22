using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    //Reloads the scene when the function is ran
    public void buttonRetry()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        PauseMenuController.isPaused = false;
        Score.scoreVal = 0;
        GameManager.gameIsOver = false;
    }
}
