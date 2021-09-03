using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] Vector3 point;

    [SerializeField] float angle;
    
    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
    void Rotate()
    {
        transform.RotateAround(point, Vector3.forward, angle * Time.deltaTime);
    }
}
