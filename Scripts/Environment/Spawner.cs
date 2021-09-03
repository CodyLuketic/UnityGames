using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject block;

    [SerializeField] float spawnTime;
    
    private Vector3 Min;
    private Vector3 Max;

    private float xAxis;

    private Vector3 randomPosition;

    private void Start()
    {
        SetRanges();
        InvokeRepeating("InstantiateRandomBlocks", spawnTime, spawnTime);
    }
    private void Update()
    {
        RandomPosition();
    }
 
    private void SetRanges()
    {
        Min = new Vector3(-6, 4, 0);
        Max = new Vector3(6, 40, 30);
    }

    private void InstantiateRandomBlocks()
    {
        Instantiate(block, randomPosition, Quaternion.identity);
    }

    private void RandomPosition()
    {
        xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        randomPosition = new Vector3(xAxis, 10, 0);
    }
}
