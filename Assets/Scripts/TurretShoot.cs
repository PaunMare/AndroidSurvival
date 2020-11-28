using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    public Transform target;
    public float range = 15f;
    public float fireCooldown = 1f;
    private float fireCountdown = 0f;
    //public Transform firePoint;
    public Transform bullet;
    private void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.3f);
    }
    public void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
            target = null;
    }
    private void Update()
    {
        if(target == null)
        {
            return;
        }

        //Vector3 dir = target.position - transform.position;
        //Quaternion lookRootation = Quaternion.LookRotation(dir);
        //Vector3 rotation = lookRootation.eulerAngles;
        //firePoint.rotation = Quaternion.Euler(0f, 0f, rotation.z);
        Vector3 vectorToTarget = target.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 50f);
        if (fireCountdown <= 0)
        {
            Shoot();
            fireCountdown = 1f / fireCooldown;
        }
        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
