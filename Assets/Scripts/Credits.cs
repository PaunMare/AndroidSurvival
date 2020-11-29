using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MainMenu", 18f);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
