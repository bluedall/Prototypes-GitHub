using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is responsible for Rotate Camera using mouse.
/// </summary>
public class Player_RotateCamera : MonoBehaviour
{
    [SerializeField] float sensitivity = 100.0f;
    [SerializeField] Transform playerBody;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        RotateWithMouse();
    }


    [SerializeField] float Min_Y;
    [SerializeField] float Max_Y;

    float xRotation = 0.0f;
    void RotateWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
       
    }

}
