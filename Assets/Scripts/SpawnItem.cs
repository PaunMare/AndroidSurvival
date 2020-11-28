using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public static GameObject selectedObject;

    public void Spawn()
    {
        //Vector3 v3 = transform.position;
        //v3.x += 5f;
        Instantiate(selectedObject, transform.position, transform.rotation);
    }

    public void SetItem(GameObject go)
    {
        selectedObject = go;
    }
}
