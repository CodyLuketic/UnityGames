using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDamage : MonoBehaviour
{
    [SerializeField] float damage;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        GunnerLife gunnerLife = hitInfo.GetComponent<GunnerLife>();
        if (gunnerLife != null)
        {
            gunnerLife.TakeDamage(damage);
        }
    }
}
