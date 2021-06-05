using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    void Start()
    {
        Invoke("MainMenu", 18f);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
