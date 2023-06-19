using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;

    public float spawnTime;
    public float spawnDelay;
    public float destroyDelay;

    void Start()
    {
        InvokeRepeating("SpawnBullet", spawnTime, spawnDelay);
    }

    public void SpawnBullet()
    {
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(tempBullet, destroyDelay);
    }    
}
