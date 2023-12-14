using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnCollision : MonoBehaviour
{
    [SerializeField] private GameObject crowbarObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == crowbarObject)
        {
            gameObject.SetActive(false);
        }
    }
}
