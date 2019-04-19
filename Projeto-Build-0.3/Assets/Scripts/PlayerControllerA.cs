using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerA : MonoBehaviour
{
    public float moveSpeedA = 3;

    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public string axisX, axisY; //input

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw(axisX), 0, Input.GetAxisRaw(axisY)) * moveSpeedA; //movimenta o player
        moveVelocity = moveInput * moveSpeedA; 
    }


    private void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity; //seta a velocidade
    }
}


