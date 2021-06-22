using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Variable, Component and Game Object References
    public GameObject GameOverScreen;
    public static bool gameIsOver = false;
    public Score score;
    public Text scoreGameOver;

    // Start is called before the first frame update
    void Start()
    {
        //Getting the component of type Score and deactivating the game over screen
        score.GetComponent<Score>();
        GameOverScreen.SetActive(false);
    }
    //This function checks if gameIsOver is equal to false, then activates game over screen
    public void GameOver()
    {
        if (gameIsOver == false)
        {
            //Sets the gameIsOver value to true and sets up the rest of the game over screen
            gameIsOver = true;
            GameOverScreen.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }



}
