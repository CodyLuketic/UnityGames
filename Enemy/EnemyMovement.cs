using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private float moveSpeed;

    private bool allowMovement = true;

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if (allowMovement)
        {
            transform.LookAt(player);

            transform.position += transform.forward * moveSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pit"))
        {
            allowMovement = false;
        }
    }
}
