using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabMoney : MonoBehaviour
{
    [SerializeField]private AudioSource _sonMoney;
    

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Money"))
        {
            PrendreMoney(other.gameObject);
        }
    }
    public void PrendreMoney(GameObject moneyObject)
    {
        _sonMoney.Play();

        // Vous pouvez choisir entre Destroy et SetActive en fonction de vos besoins.

        // Option 1: Détruire l'objet
        Destroy(moneyObject);

        // Option 2: Désactiver l'objet (commentez la ligne ci-dessus si vous utilisez celle-ci)
        // moneyObject.SetActive(false);

        Debug.Log("Objet Money pris !");
    }*/

    /*gameObject.tag = "Money";
    public void PrendreMoney()
    {
        _sonMoney.Play();

        Destroy(gameObject.tag.CompareTag("Money"));
        //gameObject.SetActive(false);
        Debug.Log("oui");

    }*/
}

