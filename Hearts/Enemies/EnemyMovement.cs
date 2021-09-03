using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject startPoint;
    [SerializeField] private GameObject endPoint;
    [Space]

    [SerializeField] private float speed = 3f;
    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position = Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, Mathf.PingPong(Time.time * speed, 1.0f));

    }
}
