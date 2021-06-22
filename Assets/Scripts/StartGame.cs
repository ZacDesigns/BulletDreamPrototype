using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //Loads the gameplay scene when ran
    public void buttonStart()
    {
        SceneManager.LoadScene(1);
    }

}
