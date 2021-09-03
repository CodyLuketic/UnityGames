using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerFollowMouse : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }
}
