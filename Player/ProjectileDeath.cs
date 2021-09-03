using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDeath : MonoBehaviour
{
    [SerializeField] private float timeTillDestroySelf;
    [SerializeField] private float power;

    private void Update()
    {
        Invoke("DestroySelf", timeTillDestroySelf);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (collision.gameObject.CompareTag("Enemy"))
        {
            DestroySelf();

            rb.AddForceAtPosition(transform.forward * power, transform.position);
        }
    }
}
