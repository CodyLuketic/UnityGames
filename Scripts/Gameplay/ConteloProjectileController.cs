using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConteloProjectileController: MonoBehaviour
{
    [SerializeField] float projectileSpeed;
    [SerializeField] float damage;

    [SerializeField] GameObject projectile;
    [SerializeField] Transform projectileLocation;
    [SerializeField] GameObject projectileHit;

    void FixedUpdate()
    {
        ProjectileMovement();
    }
    void ProjectileMovement()
    {
        transform.Translate(Vector2.up* Time.deltaTime* projectileSpeed);
}
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        GunnerLife gunnerLife = hitInfo.GetComponent<GunnerLife>();
        if (gunnerLife != null)
        {
            gunnerLife.TakeDamage(damage);
        }

        BlockerDestruction blockerDestruction = hitInfo.GetComponent<BlockerDestruction>();
        if (blockerDestruction != null)
        {
            blockerDestruction.TakeDamage(damage);
        }
        Instantiate(projectileHit, projectileLocation.position, Quaternion.identity);
        Destroy(projectile);
    }
}
