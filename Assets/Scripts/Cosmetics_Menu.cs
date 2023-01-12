using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosmetics_Menu : MonoBehaviour
{
    int Click = 0;
    public Canvas Cosmetic_menu;

    public void Show()
    {
        if (Click % 2 == 0)
        {
            Cosmetic_menu.enabled = true;
        }
        else
        {
            Cosmetic_menu.enabled = false;
        }
        Click++;
    }
    public void Show_True()
    {
        Cosmetic_menu.enabled = true;
    }
    public void Show_False()
    {
        Cosmetic_menu.enabled = false;
    }
}
