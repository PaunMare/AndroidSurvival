using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseItem : MonoBehaviour
{
    public GameObject selectedItem;
    public List<Button> spawnablePlaces;
    public void Buy()
    {
        foreach(Button b in spawnablePlaces)
        {
            b.enabled = true;
        }
        GameObject[]gameObjects = GameObject.FindGameObjectsWithTag("SpawnablePlaces");
        foreach(GameObject game in gameObjects)
        {
            game.GetComponent<SpawnItem>().SetItem(selectedItem);
        }
    }
}
