using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Menu : MonoBehaviour
{
    public Canvas Reset;

    public void Show_True()
    {
        Reset.enabled = true;
    }
    public void Show_False()
    {
        Reset.enabled = false;
    }
}
