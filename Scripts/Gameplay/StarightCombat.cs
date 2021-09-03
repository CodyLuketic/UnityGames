using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarightCombat : MonoBehaviour
{
    [SerializeField] GameObject blocker;
    [SerializeField] GameObject projectile;
    GameObject[] projectileSpawner;

    [SerializeField] float spawnFrequency;
    float spawnTimer = 0f;

    void Start()
    {
        projectileSpawner = GameObject.FindGameObjectsWithTag("Spawnable");
    }

    // Update is called once per frame
    void Update()
    {

        if (blocker == null)
        {
            Combat();
        }
        
    }

    void Combat()
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
        for (var i = 0; i < projectileSpawner.Length; i++)
        {
            var spawn = projectileSpawner[i];
            Instantiate(projectile, new Vector2(spawn.transform.position.x, spawn.transform.position.y), spawn.transform.rotation);
        }
    }


    public float health;
    [SerializeField] Slider slider;

    [SerializeField] GameObject deathEffect;
    public void TakeDamage(float damage)
    {
        health -= damage;
        SetHealth();
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void SetHealth()
    {
        slider.value = health;
    }
}
