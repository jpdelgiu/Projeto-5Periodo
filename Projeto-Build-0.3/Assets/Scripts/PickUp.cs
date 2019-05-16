using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    public Transform player;

    public float throwForce = 10;

    bool hasPlayer = false;
    bool beingCarried = false;

    public string interaction;

    void OnTriggerEnter(Collider other)
    {
        hasPlayer = true;
    }

    void OnTriggerExit(Collider other)
    {
        hasPlayer = false;
    }

    void Update()
    {
        if (beingCarried)
        {
            if (Input.GetButtonDown(interaction))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                //rigidbody.isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(player.forward * throwForce);
            }
        }
        else
        {
            if (Input.GetButtonDown(interaction) && hasPlayer)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = player;
                beingCarried = true;
            }
        }
    }
}