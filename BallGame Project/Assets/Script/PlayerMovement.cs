using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed = 0;
    private float maxSpeed = 300;
    // private Vector3 movingDirection = Vector3();
    private Rigidbody rb;
    private bool isMoving;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {


    }

    void OnMove(InputValue movementValue){
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void FixedUpdate(){
        Vector3 movement = new Vector3(movementX, 0.0f,  movementY);
        rb.AddForce(movement * speed);
    }
}
