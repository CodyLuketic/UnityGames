using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public GameObject pickupEffect;
    public float seconds = 6;
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerMovement movement = other.gameObject.GetComponent<PlayerMovement>();

            Pickup();

            if (movement)
            {
                // We speed up the player and then tell to stop after a few seconds
                movement.slowDown = .4f;
                yield return new WaitForSeconds(seconds);
                movement.StopSpeedUp();
            }
            Destroy(gameObject);
        }
    }

    void Pickup()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
    }
}
