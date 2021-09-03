using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController: MonoBehaviour
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
        transform.Translate(Vector2.up * Time.deltaTime * projectileSpeed);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        ConteloLife conteloLife = hitInfo.GetComponent<ConteloLife>();
        if (conteloLife != null)
        {
            conteloLife.TakeDamage(damage);
        }
        Instantiate(projectileHit, projectileLocation.position, Quaternion.identity);
        Destroy(projectile);

        EnemyLife enemyLife = hitInfo.GetComponent<EnemyLife>();
        if (enemyLife != null)
        {
            enemyLife.TakeDamage(damage);
        }
        Instantiate(projectileHit, projectileLocation.position, Quaternion.identity);
        Destroy(projectile);

        StarightCombat starightLife = hitInfo.GetComponent<StarightCombat>();
        if (starightLife != null)
        {
            starightLife.TakeDamage(damage);
        }
        Instantiate(projectileHit, projectileLocation.position, Quaternion.identity);
        Destroy(projectile);
    }
}
