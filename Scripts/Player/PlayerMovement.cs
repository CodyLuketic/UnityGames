using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float speed;

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(target.transform.position, Vector3.forward, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(target.transform.position, Vector3.forward, -speed * Time.deltaTime);
        }
    }
}
