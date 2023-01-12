using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Move_Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Update is called once per frame
    public Rigidbody rb;
    public float sidewayForce = 500;
    public bool buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    void FixedUpdate()
    {
        if (buttonPressed)
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

}
