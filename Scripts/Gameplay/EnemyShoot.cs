using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject projectileSpawner;

    [SerializeField] float spawnFrequency;
    float spawnTimer = 0f;
    // Update is called once per frame
    void Update()
    {
        ActivateSpawn();
    }

    void ActivateSpawn()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnFrequency)
        {
            Spawn();
            spawnTimer = 0f; //Reset
        }
    }

    void Spawn()
    {
        Instantiate(projectile, new Vector2(projectileSpawner.transform.position.x, projectileSpawner.transform.position.y), projectileSpawner.transform.rotation);
    }
}
