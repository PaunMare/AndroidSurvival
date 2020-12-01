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
    void Awake()
    {
        nickname = PlayerPrefs.GetString("name");
        score = PlayerPrefs.GetInt("score");
        text.text = "Name: " + nickname + "\nscore: " + score.ToString();
        bestNick = PlayerPrefs.GetString("bestNick");
        bestScore = PlayerPrefs.GetInt("bestScore");
        bestText.text = "Name: " + bestNick + "\nscore: " + bestScore.ToString();
    }
    public void StartTheGame()
    {
        SceneManager.LoadScene(2);
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