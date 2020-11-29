using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> spawningPosition;
    public float spawnTime = 5f;
    float nextSpawn = 3f;
    float currentTime = 0f;
    public Text timer;
    public float time = 0;
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > nextSpawn)
        {
            SpawnEnemy();
            nextSpawn += spawnTime;
        }
        time += 1 * Time.deltaTime;
        timer.text = currentTime.ToString("0");
        InvokeRepeating("PowerUp", 10f, 10f);
    }
    public void SpawnEnemy()
    {
        int i = Random.Range(0, spawningPosition.Count);
        GameObject enemy =  Instantiate(enemyPrefab, spawningPosition[i].gameObject.transform);
        
       
    }
    public void PowerUp()
    {
        if(spawnTime > 1)
        {
            spawnTime -= 0.5f;
        }
    }
}
