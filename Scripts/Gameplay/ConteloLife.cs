using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConteloLife : MonoBehaviour
{
    public float health;

    [SerializeField] GameObject deathEffect;
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject healthBar;
    public Slider slider;

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
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(spawner);
        Destroy(healthBar);
    }

    public void SetHealth()
    {
        slider.value = health;
    }
}
