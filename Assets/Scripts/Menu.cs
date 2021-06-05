using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Menu : MonoBehaviour
{
    public Text text;
    public Text bestText;
    string nickname;
    string bestNick;
    int score;
    int bestScore;
    public AudioMixer audioMixer;
    public Toggle sound;
    public GameObject panelLogIn;
    public GameObject panelSignIn;
    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        panelLogIn.active = false;
        panelSignIn.active = false;
    }
    public void LogIn()
    {
        panelLogIn.active = true;
        panelSignIn.active = false;
    }
    public void SignIn()
    {
        panelLogIn.active = false;
        panelSignIn.active = true;
    }
    public void Credits()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    void Update()
    {
        if (sound.isOn)
        {
            audioMixer.SetFloat("volume", 0f);
        }
        else
            audioMixer.SetFloat("volume", -80f);
    }
    
}