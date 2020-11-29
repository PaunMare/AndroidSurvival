using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerInput : MonoBehaviour
{
    public Text text;
    public InputField input;
    int score;
    int bestScore;
    string nick;
    string bestNick;
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        bestScore = PlayerPrefs.GetInt("bestScore");
        bestNick = PlayerPrefs.GetString("bestNick");
        text.text = "Your score is: "+ score +".\nHopefully You will get more points next time.\n\nPlease enter Your name/nickname down below.";
    }

    
    public void Submit()
    {
        if (input.text != "")
        {
            if(score > bestScore)
            {
                bestScore = score;
                PlayerPrefs.SetInt("bestScore", bestScore);
                PlayerPrefs.SetString("bestNick", input.text);
            }
            PlayerPrefs.SetString("name", input.text);
            PlayerPrefs.SetInt("score", score);
            SceneManager.LoadScene(0);
        }
    }
}
