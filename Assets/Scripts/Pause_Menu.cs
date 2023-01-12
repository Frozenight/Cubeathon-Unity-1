using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    int Click = 0;
    public Canvas menu;

    public void Show()
    {
        if (Click % 2 == 0)
        {
            menu.enabled = true;
        }
        else
        {
            menu.enabled = false;
        }
        Click++;
    }
    public void Leave()
    {
        Application.Quit();
    }
    public void Continue()
    {
        menu.enabled = false;
        Time.timeScale = 1;
    }
}
