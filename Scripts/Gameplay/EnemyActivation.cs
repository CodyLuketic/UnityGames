using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActivation : MonoBehaviour
{
    GameObject[] enemies2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemies2 = GameObject.FindGameObjectsWithTag("Enemy2");
            for (int i = 0; i < enemies2.Length; i++)
            {
                enemies2[i].GetComponent<Chase>().enabled = true;
            }
            Destroy(gameObject);
        }
    }
}
