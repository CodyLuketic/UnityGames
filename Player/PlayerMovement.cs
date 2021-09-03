using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float speed;

    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.D))
        {
            rb.velocity = (transform.forward + transform.right) * speed;
        }
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D))
        {
            rb.velocity = (-transform.forward + transform.right) * speed;
        }
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.A))
        {
            rb.velocity = (-transform.forward + -transform.right) * speed;
        }
        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A))
        {
            rb.velocity = (transform.forward + -transform.right) * speed;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed;
        }
    }
}
