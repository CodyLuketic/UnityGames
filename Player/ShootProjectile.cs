using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    [Header("Projectile and Spawn Position")]
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private GameObject player;
    [SerializeField] private float distanceFromPlayer;
    [SerializeField] private float offsetHorizontal;
    [SerializeField] private float offsetVertical;
    [Space]

    private Vector3 originalRotation;

    private void Awake()
    {
        originalRotation = transform.localEulerAngles;
    }

    private void Update()
    {
        MyInput();
    }

    private void MyInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab);
        projectile.transform.position = player.transform.position + (player.transform.forward * distanceFromPlayer) + (player.transform.right * offsetHorizontal) + (player.transform.up * offsetVertical);
        projectile.transform.forward = player.transform.forward;
    }
}
