using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Canvas Settings_Menu;
    public Canvas Main_Menu;

    void Start()
    {
        var volume = PlayerPrefs.GetFloat("Volume");
        audioMixer.SetFloat("Volume", volume);
        var quality = PlayerPrefs.GetInt("Quality");
        QualitySettings.SetQualityLevel(quality);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        Settings_Menu.enabled = false;
        Main_Menu.enabled = true;
        Pause.Click++;
        PlayerPrefs.SetInt("Quality", qualityIndex);
    }
}
