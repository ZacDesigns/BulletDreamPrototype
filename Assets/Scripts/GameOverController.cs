using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    private PlayerController playerControl;

    void Start()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameOverMenu()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }


    void Update()
    {
        playerControl = GetComponent<PlayerController>();
        if (playerControl.isDead == true)
        {
            Debug.Log("Game Over");
            GameOverMenu();
        }



    }

}
