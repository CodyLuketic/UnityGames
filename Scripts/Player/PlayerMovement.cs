using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameController gameController;

    [SerializeField] float speed;

    private bool move = true;

    private Vector3 Vec;

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vec = transform.localPosition;
        if (move)
        {
            Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        }
        else
        {
            return;
        }
        transform.localPosition = Vec;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Obstacle(Clone)")
        {
            move = false;
            transform.localPosition = Vector3.zero;

            gameController.Lost();
        }
    }
}