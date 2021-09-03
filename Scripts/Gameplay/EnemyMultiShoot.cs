using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMultiShoot : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectileSpawner1;
    [SerializeField] GameObject projectileSpawner2;
    [SerializeField] GameObject projectileSpawner3;

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
        Instantiate(projectile, new Vector2(projectileSpawner1.transform.position.x, projectileSpawner1.transform.position.y), projectileSpawner1.transform.rotation);
        Instantiate(projectile, new Vector2(projectileSpawner2.transform.position.x, projectileSpawner2.transform.position.y), projectileSpawner2.transform.rotation);
        Instantiate(projectile, new Vector2(projectileSpawner3.transform.position.x, projectileSpawner3.transform.position.y), projectileSpawner3.transform.rotation);
    }
}
