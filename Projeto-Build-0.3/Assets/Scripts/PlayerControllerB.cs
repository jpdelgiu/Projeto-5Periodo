using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerB : MonoBehaviour
{
    public float moveSpeedB = 3;

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
        moveInput = new Vector3(Input.GetAxisRaw("HorizontalPlayerB"), 0, Input.GetAxisRaw("VerticalPlayerB")) * moveSpeedB;
        moveVelocity = moveInput * moveSpeedB;
    }


    private void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }
}
