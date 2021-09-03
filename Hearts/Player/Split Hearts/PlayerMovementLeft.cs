using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementLeft : MonoBehaviour
{
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float verticalSpeed;

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position += new Vector3(horizontalSpeed, 0, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(0, verticalSpeed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, -verticalSpeed, 0) * Time.deltaTime;
        }
    }
}
