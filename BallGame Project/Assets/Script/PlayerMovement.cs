using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed = 10;
    private Rigidbody rb;

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

    private void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("collectible 1")){
            other.gameObject.SetActive(false);
        }
    }
}
