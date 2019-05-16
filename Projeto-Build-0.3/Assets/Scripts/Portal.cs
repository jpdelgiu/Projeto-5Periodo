using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform player;
    public Transform receiver;
    public bool playerIsOverlaping = false;
    

    // Update is called once per frame
    void Update()
    {
        if (playerIsOverlaping)
        {
            Vector3 portalToPlayer = (player.position - transform.position);
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            // If true: player has crossed the portal
            if (dotProduct < 0f)
            {
                float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(1f, rotationDiff + 1f, 1f) * portalToPlayer;
                player.position = receiver.position + positionOffset;

                playerIsOverlaping = false;

            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            playerIsOverlaping = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            playerIsOverlaping = false;

        }
    }
}