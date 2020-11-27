using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    public Dropdown dropdown;
   public void ReturnToMM()
    {
        SceneManager.LoadScene(0);
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
    }
    public void SetQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
        PlayerPrefs.SetInt("graphics", index);
    }
    public void Awake()
    {
        float volume = PlayerPrefs.GetFloat("volume");
        int index = PlayerPrefs.GetInt("graphics");
        slider.value = volume;
        dropdown.value = index;
    }
}
