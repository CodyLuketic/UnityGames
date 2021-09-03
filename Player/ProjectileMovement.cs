using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    void FixedUpdate()
    {
        ForwardMovement();
    }

    private void ForwardMovement()
    {
        transform.position += transform.forward * speed;
    }
}
