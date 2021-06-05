using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerInput : MonoBehaviour
{
    public Text text;
    public InputField input;
    public TMP_InputField username;
    int score;
    int bestScore;
    string nick;
    string bestNick;
    int previous;
    public Text help;
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    void Start()
    {
        help.enabled = false;
        previous = PlayerPrefs.GetInt("previous");
        score = PlayerPrefs.GetInt("score");
        username.text = PlayerPrefs.GetString("user");
        //bestScore = PlayerPrefs.GetInt("bestScore");
        //bestNick = PlayerPrefs.GetString("bestNick");
        //Debug.Log("Best score: " + bestScore + " Best nick: " + bestNick);
        text.text = "Your previous score is :"+previous+"\n Your score is: "+ score +".\nHopefully You will get more points next time.";
    }

    
    public void Submit()
    {
        //if (input.text != "")
        //{
        //    help.enabled = true;
        //    if(score > bestScore)
        //    {
        //        Debug.Log("Best score: " + bestScore + " Best nick: " + bestNick);
        //        Debug.Log("Score: " + score + " Nick: " + nick);
        //        bestScore = score;
        //        PlayerPrefs.SetInt("bestScore", bestScore);
        //        PlayerPrefs.SetString("bestNick", input.text);
        //        PlayerPrefs.SetString("name", input.text);
        //        PlayerPrefs.SetInt("score", score);
        //        SceneManager.LoadScene(0);
        //    }
        //    else
        //    {
        //        PlayerPrefs.SetInt("bestScore", bestScore);
        //        PlayerPrefs.SetString("bestNick", bestNick);
        //        PlayerPrefs.SetString("name", input.text);
        //        PlayerPrefs.SetInt("score", score);
        //        SceneManager.LoadScene(0);
        //    }
            
        //}
    }
}
