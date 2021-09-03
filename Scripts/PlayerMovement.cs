using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float power;
    [SerializeField] float maxVelocity;

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * Time.deltaTime * power);
        }
    }

    private void Movement()
    {
        rb.AddForce(transform.right * Time.deltaTime * speed);

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
    }

}
