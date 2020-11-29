using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseItem : MonoBehaviour
{

    public GameObject selectedItem;
    public GameObject[] places;
    public Text currentGold;
    public int turretPrice;
    int gold;
    int newGold;
    public void Buy()
    {
        gold = int.Parse(currentGold.text);
        if (gold >= turretPrice)
        {
            newGold = int.Parse(currentGold.text);
            newGold -= turretPrice;
            currentGold.text = newGold.ToString();
            foreach (GameObject g in places)
            {
                if (g.GetComponent<SpawnItem>().free)
                {
                    g.SetActive(true);
                    g.GetComponent<SpawnItem>().SetItem(selectedItem);
                }
            }
        }
    }
    
}
