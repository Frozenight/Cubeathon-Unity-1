using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings_menu : MonoBehaviour
{
    public Canvas Settins_menu;

    public void Show_True()
    {
        Settins_menu.enabled = true;
    }
    public void Show_False()
    {
        Settins_menu.enabled = false;
    }
}
