using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Variable and Component References
    public static int scoreVal = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        //Getting the component of type text
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        //Display Score heading and score value on UI
        score.text = "Score: " + scoreVal;
    }
}
