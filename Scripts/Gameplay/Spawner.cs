using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] Transform lineStart, lineEnd;
    [SerializeField] GameObject parent;

    [SerializeField] float spawnFrequency;
    float spawnTimer = 0f;

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
        //Get Value Ranges along the line (x,y)
        float xRange = lineEnd.position.x - lineStart.position.x;
        float yRange = lineEnd.position.y - lineStart.position.y;

        //Spawn location will be somewhere betwen the lineStart and lineEnd for x, y coordinates
        Vector2 spawnLocation = new Vector2(lineStart.position.x + (xRange * UnityEngine.Random.value), lineStart.position.y + (yRange * UnityEngine.Random.value));

        GameObject projectileClone = Instantiate(projectile, parent.transform);
        projectileClone.transform.position = spawnLocation;
    }
}
