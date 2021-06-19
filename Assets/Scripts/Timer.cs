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


    void Update()
    {
        float timeCont = Time.time - startTimer;

        string minutes = ((int)timeCont / 60).ToString();
        string seconds = (timeCont % 60).ToString("f2");

        textTimer.text = minutes + ":" + seconds;



    }
}
