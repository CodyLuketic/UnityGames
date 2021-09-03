using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    GameObject[] enemies;
    [SerializeField] GameObject[] blocks;

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy"); // Checks if enemies are available with tag "Enemy". Note that you should set this to your enemies in the inspector.
        if (enemies.Length == 0)
        {
            DeleteBlocks();
        }
    }
    void DeleteBlocks()
    {
        if (GameObject.Find("Block") != null)
        {
            for (int i = 0; i < blocks.Length; i++)
            {
                Destroy(blocks[i].gameObject);
            }
        }
    }
}
