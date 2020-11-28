using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class ShopButton : MonoBehaviour
{ 
    public bool pressed;
    public GameObject shop;
    private void Awake()
    {
        shop.SetActive(false);
    }
    private void Update()
    {
        
    }
    public void ToggleShop()
    {
        pressed = !pressed;
        Shop(pressed);
    }
    public void Shop(bool turned)
    {
        if (turned)
        {
            shop.SetActive(true);
        }
        else
            shop.SetActive(false);
    }
}
