using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private float mouseX;
    private float mouseY;

    private float Xrotation = 0f;
    private float Yrotation = 0f;

    float sensitivity = 500f;

    public Transform parent;
    void Start()
    {
        Cursor.lockState =  CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
        mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;

        Xrotation += -mouseY;
        Yrotation += mouseX;

        Xrotation = Mathf.Clamp(Xrotation, -90f, 60f);

        parent.rotation = Quaternion.Euler(0, Yrotation, 0);
        transform.rotation = Quaternion.Euler(Xrotation, Yrotation, 0);
    }
}
