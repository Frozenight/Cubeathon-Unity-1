using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{ 
    public Transform Player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded != true)
        {
            score.text = (Player.position.z / 10).ToString("0");
        }
        else score.text = "game over";
    }
}
