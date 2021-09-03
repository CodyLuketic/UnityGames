using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private Vector3 spawnPoint;
    [SerializeField] private int maxX;
    [SerializeField] private int timeTilNextSpawn = 5;
    private int x = 0;
    private float timer = 0;

    void Start()
    {
        timer = 0;
        spawnPoint.x = x;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    void Spawn()
    {
        if (timer >= timeTilNextSpawn)
        {
            x = Random.Range(0, maxX);
            spawnPoint.x = x;
            Instantiate(spawnObject, spawnPoint, Quaternion.identity);
            timer = 0;
        }
    }
}
