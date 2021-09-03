using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunnerLife : MonoBehaviour
{
    [SerializeField] GameObject deathEffect;

    public float health;
    public Slider slider;
    readonly GunnerInput movement;

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
        gameObject.SetActive(false);
    }

    public void SetHealth()
    {
        slider.value = health;
    }
}
