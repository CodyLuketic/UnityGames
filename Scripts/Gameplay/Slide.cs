using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide: MonoBehaviour
{
    // Transforms to act as start and end markers for the journey.
    [SerializeField] Transform startMarker;
    [SerializeField] Transform endMarker;
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float speed;

    // Movement speed in units per second.
    void Start()
    {
        if (gameObject.CompareTag("RandomObstacle"))
        {
            speed = Random.Range(min, max);
        }
    }

    // Move to the target end position.
    void Update()
    {
        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
