using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawner : MonoBehaviour
{
    [SerializeField] GameObject boulder;

    [SerializeField] float spawnTimerMin;
    [SerializeField] float spawnTimerMax;

    void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    IEnumerator EnemySpawner()
    {
        while (true)
        {
            Instantiate(boulder, transform);

            yield return new WaitForSeconds(Random.Range(spawnTimerMin, spawnTimerMax));
        }
    }


}
