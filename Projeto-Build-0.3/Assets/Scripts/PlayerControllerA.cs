using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerA : MonoBehaviour
{
    public float moveSpeedA = 3;

    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;


    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("HorizontalPlayerA"), 0, Input.GetAxisRaw("VerticalPlayerA")) * moveSpeedA;
        moveVelocity = moveInput * moveSpeedA;
    }


    private void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }
}


