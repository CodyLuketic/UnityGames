using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    private Vector3 Vec;

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vec = transform.localPosition;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.localPosition = Vec;
    }
}
