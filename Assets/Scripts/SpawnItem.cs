using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SpawnItem : MonoBehaviour, IPointerDownHandler
{
    public static GameObject selectedObject;
    GameObject turret;
    GameObject[] objects;
    public List<int> takenPlaces;
    public bool free = true;
    public void Spawn()
    {
        objects = GameObject.FindGameObjectsWithTag("SpawnablePlaces");
        turret =   Instantiate(selectedObject, transform.parent.position.normalized, transform.parent.rotation.normalized);
        free = false;
        turret.transform.position = this.transform.position;
        Time.timeScale = 1f;
        turret.transform.position = new Vector3(turret.transform.position.x, turret.transform.position.y, 0f);
        foreach(GameObject go in objects)
        {
            go.gameObject.SetActive(false);
        }
        Invoke("DestroyTurret", 30f);
    }
    

    public void SetItem(GameObject go)
    {
        selectedObject = go;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Spawn();
    }
   public void DestroyTurret()
    {
        Destroy(turret.gameObject);
        free = true;
    }
}

