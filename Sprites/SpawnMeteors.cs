using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteors : MonoBehaviour
{
    [SerializeField] GameObject meteor;
    [SerializeField] float radius;
    [SerializeField] float respawnTime;

    private Vector3 center;

    Vector3 RandomCircle(float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }

    void Start()
    {
        center = transform.position;
        StartCoroutine(Asteroids());
    }

    private void SpawnRandom()
    {
        Vector3 pos = RandomCircle(radius);
        Instantiate(meteor, pos, Quaternion.identity);
    }

    IEnumerator Asteroids()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnRandom();
        }
    }
}
