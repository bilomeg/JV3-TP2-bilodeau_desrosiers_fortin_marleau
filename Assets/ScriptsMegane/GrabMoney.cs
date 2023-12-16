using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabMoney : MonoBehaviour
{

    [SerializeField] private AudioSource _sonMoney;
    private bool isGrabbed = false;

    private void PrendreMoney()
    {
        if (isGrabbed)
        {
            _sonMoney.Play();
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Main"))
        {
            // Marquer comme grabbé
            isGrabbed = true;

            // Démarrer une coroutine pour attendre un certain délai (par exemple, 0.5 secondes)
            StartCoroutine(WaitForGrab());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Main"))
        {
            // Réinitialiser l'état grabbé lorsque la main quitte la zone
            isGrabbed = false;
        }
    }

    private System.Collections.IEnumerator WaitForGrab()
    {
        // Attendre un court délai (0.5 secondes par exemple)
        yield return new WaitForSeconds(0.5f);

        // Appeler PrendreMoney après le délai
        PrendreMoney();
    }

}

