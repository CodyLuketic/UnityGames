using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject banana;

    [SerializeField] float spawnTime;
    
    private Vector3 Min;
    private Vector3 Max;

    private float xAxis;

    private Vector3 randomPosition;

    private void Start()
    {
        SetRanges();
        InvokeRepeating("InstantiateRandomBananas", spawnTime, spawnTime);
    }
    private void Update()
    {
        RandomPosition();
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(-6, 4, 0); //Random value.
        Max = new Vector3(6, 40, 30); //Another ramdon value, just for the example.
    }
    private void InstantiateRandomBananas()
    {
        Instantiate(banana, randomPosition, Quaternion.identity);
    }

    private void RandomPosition()
    {
        xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        randomPosition = new Vector3(xAxis, 6, 0);
    }
}
