using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Menu : MonoBehaviour
{
    public void StartGame()
    { 
            try
            {
                string Data = PlayerPrefs.GetString("Current_Level");
                int LevelIndex = int.Parse(Data);
                SceneManager.LoadScene(LevelIndex);
            }
            catch
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
    }
}
