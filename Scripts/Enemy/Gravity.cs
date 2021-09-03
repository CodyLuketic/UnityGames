using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float accelerationDueToGravity = 9.8f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        CreateGravity();
    }

    private void CreateGravity()
    {
        //Define our gravity origin in world space. (This could be an objects transform.position )
        Vector3 gravityOrigin = new Vector3(0.0f, 0.0f, 0.0f);

        //Get a vector to our gravity origin from object and normalize.
        Vector3 toGravityOriginFromObject = gravityOrigin - gameObject.transform.position;
        toGravityOriginFromObject.Normalize();

        //Multiply vector so that the magnitude is equal to the force we wish to apply.
        toGravityOriginFromObject *= accelerationDueToGravity * rb.mass * Time.deltaTime;

        //Apply our acceleration.
        rb.AddForce(toGravityOriginFromObject, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            accelerationDueToGravity = -9.8f;
        }
    }
}
