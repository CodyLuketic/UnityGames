using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrorMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        rb.velocity = (-transform.right * speed);
    }
}
