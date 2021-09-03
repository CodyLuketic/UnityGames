using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrorMinionCircle : MonoBehaviour
{
    [SerializeField] Transform centerPoint;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(centerPoint.position, Vector3.forward, Random.Range(1, 600) * Time.deltaTime);
    }
}
