using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Reset : MonoBehaviour
{
    public void Reset_Saved_Level()
    {
        PlayerPrefs.SetString("Current_Level", 1.ToString());
    }
    public void Load_First_Level()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
