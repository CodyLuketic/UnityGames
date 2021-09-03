using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;

public class PlayerMovement : MonoBehaviour
{
    // Added a reference to Rigibody in the form of rb
    public Rigidbody rb;

    public float slowDown = 1f;
    public float forwardForce = 2000f;
    public float xForce = 500f;
    internal new bool enabled;

    // Update is called once per frame
    // We marked this as "Fixed"Update because we are using it to mess with physics
    public void FixedUpdate()
    {
        // Time.deltaTime Evens out different computer frame rate
        rb.AddForce(0, 0, forwardForce * Time.deltaTime * slowDown);

        if (rb.position.y < -1f || rb.position.x > 8f || rb.position.x < -8f) // If the player falls below 1 unit
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            if (Input.GetKey("d")) // If the player is pressing the "d" key
            {
                // Add a force to the right
                rb.AddForce(xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a")) // If the player is pressing the "a" key
            {
                // Add a force to the left
                rb.AddForce(-xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (rb.position.y < -1f || rb.position.x > 8f || rb.position.x < -8f) // If the player falls below 1 unit
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
    public void StopSpeedUp()
    {
        slowDown = 1.0f; // back to normal !
    }
}
