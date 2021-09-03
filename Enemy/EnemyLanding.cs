using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnemyLanding : MonoBehaviour
{
    private float arenaCollideCount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arena") & arenaCollideCount == 0)
        {
            GetComponent<AudioSource>().Play();

            arenaCollideCount++;
        }
    }
}
