using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> spawningPosition;
    public float spawnTime = 5f;
    float nextSpawn = 3f;
    float currentTime = 0f;
    

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > nextSpawn)
        {
            SpawnEnemy();
            nextSpawn += spawnTime;
        }
    }
    public void SpawnEnemy()
    {
        int i = Random.Range(0, spawningPosition.Count);
        GameObject enemy =  Instantiate(enemyPrefab, spawningPosition[i].gameObject.transform);
        
        Debug.Log(i.ToString());
    }
    
}
