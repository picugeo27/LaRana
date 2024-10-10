using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float dragForce = 1f;

    float horizontalInput;
    float verticalInput;

    Vector3 direction;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
        _rb.drag = dragForce;
    }

    void Update()
    {
        handleInput();
    }

    private void FixedUpdate()
    {
        movePlayer();
    }

    void handleInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void movePlayer()
    {
        direction = transform.forward * verticalInput + transform.right * horizontalInput;
        _rb.AddForce(direction * speed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
