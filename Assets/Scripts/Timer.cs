using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Variable and Component References
    public static string timerValue;
    public Text textTimer;
    public Text textGameOver;
    private float startTimer;


    // Start is called before the first frame update
    void Start()
    {
        startTimer = Time.time;
        textTimer = GetComponent<Text>();

    }

    //Keeps track of the time spent playing since the player has started gameplay
    public void timerCount()
    {
        //If gameIsOver is not true, run the function
        if (!GameManager.gameIsOver)
        {
            float timeCont = Time.time - startTimer;

            string minutes = ((int)timeCont / 60).ToString();
            string seconds = (timeCont % 60).ToString("f2");

            textTimer.text = "Timer: " + minutes + ":" + seconds;
        }
        //Get timer text components for game over screen
        timerValue = textTimer.GetComponent<Text>().text;
        textGameOver.GetComponent<Text>().text = timerValue;

    }


    // Update is called once per frame
    void Update()
    {
        //function timerCount is called in update
        timerCount();
    }
}
