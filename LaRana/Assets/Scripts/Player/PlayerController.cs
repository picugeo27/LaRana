using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // componentes
    private CharacterController _controller;
    private Vector3 currentDirection = Vector3.zero;
    private Vector3 _speed;

    // Salto
    private float _gravity = -9.8f;
    private bool _onFloor;

    private float currentX = 0;
    private float currentZ = 0;
    private float interpolation = 10;

    [Header("Stats")]
    public float speed;
    public float turnTime = 0.2f;
    public float jumpHeight = 3;
    public float jumpForce = -2;

    [Header("References")]
    public Transform floor;
    public Transform camera;

    private float floorDistance = 0.1f;
    public LayerMask layerFloor;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }

    private void Walk()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if (x != 0 || z != 0)
        {
            currentX = Mathf.Lerp(currentX, x, Time.deltaTime * interpolation);
            currentZ = Mathf.Lerp(currentZ, z, Time.deltaTime * interpolation);

            Vector3 direction = camera.forward * currentZ + camera.right * currentX;

            float directionLength = direction.magnitude;
            direction.y = 0;
            direction = direction.normalized * directionLength;
            currentDirection = Vector3.Slerp(currentDirection, direction, Time.deltaTime * interpolation);

            transform.rotation = Quaternion.LookRotation(currentDirection);
            _controller.Move(currentDirection.normalized * speed * Time.deltaTime);


        }
    }

    private void Jump()
    {
        _onFloor = Physics.CheckSphere(floor.position, floorDistance, layerFloor);
        
        if (_onFloor && _speed.y < 0) {
            _speed.y = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && _onFloor)
        {
            _speed.y = Mathf.Sqrt(jumpHeight * jumpForce);
        }
        _speed.y += _gravity * Time.deltaTime;
        _controller.Move(_speed * Time.deltaTime);
    }
}
