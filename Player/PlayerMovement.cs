using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement(){
        if(Input.GetKey(KeyCode.A)){
            rb.velocity = -transform.right * speed;
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.velocity = transform.right * speed;
        }
        else{
            rb.velocity = Vector3.zero;
        }
    }
}
