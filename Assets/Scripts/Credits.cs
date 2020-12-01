using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    
    void Start()
    {
        Invoke("MainMenu", 18f);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
