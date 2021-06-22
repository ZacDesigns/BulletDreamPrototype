using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static string timerValue;
    public Text textTimer;
    public Text textGameOver;
    private float startTimer;



    void Start()
    {
        startTimer = Time.time;
        textTimer = GetComponent<Text>();

    }


    public void timerCount()
    {
        if (!GameManager.gameIsOver)
        {
            float timeCont = Time.time - startTimer;

            string minutes = ((int)timeCont / 60).ToString();
            string seconds = (timeCont % 60).ToString("f2");

            textTimer.text = "Timer: " + minutes + ":" + seconds;
        }
        timerValue = textTimer.GetComponent<Text>().text;
        textGameOver.GetComponent<Text>().text = timerValue;

    }



    void Update()
    {
        timerCount();
    }
}
