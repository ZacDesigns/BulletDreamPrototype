using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text textTimer;
    private float startTimer;



    void Start()
    {
        startTimer = Time.time;


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
    }



    void Update()
    {
        timerCount();
    }
}
