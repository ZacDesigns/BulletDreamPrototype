using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    private PlayerController playerControl;

    void Start()
    {
        playerControl = GetComponent<PlayerController>();
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
        if (playerControl.isDead == true)
        {
            Debug.Log("Game Over");
            GameOverMenu();
        }



    }

}
