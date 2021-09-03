using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    private GameObject playerCamera;

    private bool cameraTurned = false;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        TurnCamera();
    }

    private void TurnCamera()
    {
        if (Input.GetKeyDown(KeyCode.Tab) & cameraTurned)
        {
            playerCamera.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            cameraTurned = true;
        }
        if (Input.GetKeyDown(KeyCode.Tab) & !cameraTurned)
        {
            playerCamera.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            cameraTurned = false;
        }
    }
}
