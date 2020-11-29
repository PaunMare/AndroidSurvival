using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class EnemyFollow : MonoBehaviour
{
    public float moveSpeed;
    private Transform target;
    private NavMeshAgent agent;
    public int healthPoints=20;
    Text goldEarned,enemiesKilled;
    int currentGold;
    int gold = 1;
    int damageTaken = 10;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateUpAxis = false;
        agent.updateRotation = false;
        InvokeRepeating("PowerUp", 2f, 3f);
        goldEarned = GameObject.FindGameObjectWithTag("Gold").GetComponent<Text>();
        enemiesKilled = GameObject.FindGameObjectWithTag("EnemiesKilled").GetComponent<Text>();
    }

    void Update()
    {
        agent.SetDestination(target.position);
        if(healthPoints <= 0)
        {
            int currentEnemies = int.Parse(enemiesKilled.text);
            currentEnemies++;
            currentGold = int.Parse(goldEarned.text);
            currentGold += gold;
            goldEarned.text = currentGold.ToString();
            enemiesKilled.text = currentEnemies.ToString() ;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            healthPoints -=damageTaken;
        }
    }

    public void PowerUp()
    {
        if (damageTaken > 5)
        {
            healthPoints += 2;
            //damageTaken -= 1;
            moveSpeed += 0.1f;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 0.015f, gameObject.transform.localScale.y + 0.015f, gameObject.transform.localScale.z);
        }
    }
}
