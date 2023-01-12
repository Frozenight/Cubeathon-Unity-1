using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Cube_Color : MonoBehaviour
{
    public GameObject Player;
    private Color NewColor = Color.yellow;

    public void Change_Color_Red()
    {
        NewColor = Color.red;
        var cubeRenderer = Player.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", NewColor);
        Save();
    }
    public void Change_Color_Yellow()
    {
        NewColor = Color.yellow;
        var cubeRenderer = Player.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", NewColor);
        Save();
    }
    public void Change_Color_green()
    {
        NewColor = Color.green;
        var cubeRenderer = Player.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", NewColor);
        Save();
    }
    public void Change_Color_white()
    {
        NewColor = Color.white;
        var cubeRenderer = Player.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", NewColor);
        Save();
    }
    public void Change_Color_black()
    {
        NewColor = Color.black;
        var cubeRenderer = Player.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", NewColor);
        Save();
    }
    public void Change_Color_cyan()
    {
        NewColor = Color.cyan;
        var cubeRenderer = Player.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", NewColor);
        Save();
    }
    void Update()
    {
            Load();
    }
    void Save()
    {
        string a = Player.GetComponent<Renderer>().material.color.a.ToString();
        string b = Player.GetComponent<Renderer>().material.color.b.ToString();
        string g = Player.GetComponent<Renderer>().material.color.g.ToString();
        string r = Player.GetComponent<Renderer>().material.color.r.ToString();
        string[] contents = new string[] { "" + a, "" + b, "" + g, "" + r };
        string Color = string.Join(" ", contents);
        PlayerPrefs.SetString("Cube_Color", Color);
    }
    void Load()
    {
            string color = PlayerPrefs.GetString("Cube_Color");
            string[] parts = color.Split(' ');
            float a = float.Parse(parts[0]);
            float b = float.Parse(parts[1]);
            float g = float.Parse(parts[2]);
            float r = float.Parse(parts[3]);
            Color CubeColour = new Color(r, g, b, a);
            var cubeRenderer = Player.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", CubeColour);
    }
}
