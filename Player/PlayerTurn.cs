using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private float mouseSensitivity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        CameraVerticalRotateToMouse();
    }

    private void CameraVerticalRotateToMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * mouseX);
    }
}
