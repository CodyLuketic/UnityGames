using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrorMinionStrafe : MonoBehaviour
{
    [SerializeField] private GameObject startPoint;
    [SerializeField] private GameObject endPoint;
    [Space]

    private float speed;
    // Update is called once per frame
    private void Start()
    {
        speed = Random.Range(0f, 0.2f);
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position = Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
