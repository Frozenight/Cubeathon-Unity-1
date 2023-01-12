using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public static int Click = 0;
    public Canvas paused;


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseTheGame();
            Show();
        }
    }

    public void PauseTheGame()
    {

        if (Click % 2 == 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void Show()
    {
        if (Click % 2 == 0)
        {
            paused.enabled = true;
        }
        else
        {
            paused.enabled = false;
        }
        Click++;
    }
    public void ShowTrue()
    {
        paused.enabled = true;
    }
    public void ShowFalse()
    {
        paused.enabled = false;
    }
}
