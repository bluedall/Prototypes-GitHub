using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RotateCamera : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        RotateWithMouse();
    }

    void RotateWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * mouseX);

        //Inverse Y mouse movement
        mouseY = mouseY * -1;
        float angle = Mathf.Clamp(mouseY, -90, 90);
        //if (transform.eulerAngles.x < 40 && transform.eulerAngles.x > -15)
            transform.Rotate(angle, 0f, 0f);

        transform.eulerAngles = new Vector3(Mathf.Clamp(transform.eulerAngles.x, -15, 40), transform.eulerAngles.y, transform.eulerAngles.z);
    }

}
