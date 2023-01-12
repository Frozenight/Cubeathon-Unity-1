using UnityEngine;
using System.Threading;

public class SpeedDecrease : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager GameManager;
    public float IncreasedSpeed = 2000f;

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            for (int i = 0; i < 4; i++)
            {
                movement.rb.AddForce(0, 0, IncreasedSpeed * Time.deltaTime);
            }
        }
    }
}
