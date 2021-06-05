using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Victory : MonoBehaviour
{
    public Text text;
    public InputField input;
    int score;
    int bestScore;
    string nick;
    string bestNick;
    public Text help;
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    void Start()
    {
        help.gameObject.SetActive(false);
        score = PlayerPrefs.GetInt("score");
        bestScore = PlayerPrefs.GetInt("bestScore");
        bestNick = PlayerPrefs.GetString("bestNick");
        text.text = "Congratulations challenger! You've managed to clear the first wave of Covid Assault. But, don't be careless, no one knows when the next wave will come.\nYour score is: " + score+".\nPlease enter your name down below,";
    }

    public void Submit()
    {
        if (input.text != "")
        {
            if (score > bestScore)
            {
                bestScore = score;
                PlayerPrefs.SetInt("bestScore", bestScore);
                PlayerPrefs.SetString("bestNick", input.text);
                PlayerPrefs.SetString("name", input.text);
                PlayerPrefs.SetInt("score", score);
                SceneManager.LoadScene(0);
            }
            else
            {
                PlayerPrefs.SetInt("bestScore", bestScore);
                PlayerPrefs.SetString("bestNick", bestNick);
                PlayerPrefs.SetString("name", input.text);
                PlayerPrefs.SetInt("score", score);
                SceneManager.LoadScene(0);
            }

        }
        else
        {
            help.gameObject.SetActive(true);
        }
    }
}
