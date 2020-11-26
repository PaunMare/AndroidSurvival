using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public Text text;
    string nickname;
    int score;

    void Awake()
    {
        text.text = "Name: " + nickname + "\nscore: " + score.ToString();
    }
    public void Options()
    {
        SceneManager.LoadScene(1);
    }
    public void StartTheGame()
    {
        SceneManager.LoadScene(3);
    }
    public void Credits()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
}