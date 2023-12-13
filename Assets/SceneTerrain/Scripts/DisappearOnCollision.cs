using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggered the collider is the crowbar.
        if (other.CompareTag("Crowbar2"))
        {
            // If the collider belongs to the crowbar, make the planks disappear.
            gameObject.SetActive(false);
        }
    }
}
