using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GrabMoney : MonoBehaviour
{

    [SerializeField] private TMP_Text _texteNbPoints;
    [SerializeField] private InfosNiveau _infosNiveau;
    [SerializeField] private AudioSource _sonMoney;

    private int _moneyValeur = 100;
     private int _bijouxValeur = 250;
 private int _valiseValeur = 500;
     private int _lignotsValeur = 1000;

    private bool isGrabbed = false;
[SerializeField] private ListeObjectifs _listeObjectifs;
        [SerializeField] private GameObject _crochetMeg1;
     [SerializeField] private GameObject _crochetMeg2;
         [SerializeField] private GameObject _crochetMeg3;
     [SerializeField] private GameObject _crochetMeg4;
  void Update()
    {
        AfficherPoints();
    }
    public void AfficherPoints(){
       
       _texteNbPoints.text = _infosNiveau._nbPoints.ToString()+"  $";
         
    }
    private void PrendreMoney(int valeur)
    {
        if (isGrabbed)
        {
            _sonMoney.Play();
            gameObject.SetActive(false);
            _infosNiveau._nbPoints += valeur;
            AfficherPoints();
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
        if (gameObject.CompareTag("Money"))
        {
            PrendreMoney(_moneyValeur);
            _listeObjectifs.ObjectifAccompli("RamasserArgent");
            _crochetMeg1.SetActive(true);
        }
        else if (gameObject.CompareTag("Bijoux"))
        {
            PrendreMoney(_bijouxValeur);
            _listeObjectifs.ObjectifAccompli("RamasserBijou");
             _crochetMeg2.SetActive(true);
        }
        else if (gameObject.CompareTag("Valises"))
        {
            PrendreMoney(_valiseValeur);
            _listeObjectifs.ObjectifAccompli("RamasserValise");
             _crochetMeg3.SetActive(true);
        }
        else if (gameObject.CompareTag("Lignots"))
        {
            PrendreMoney(_lignotsValeur);
            _listeObjectifs.ObjectifAccompli("RamasserLingot");
             _crochetMeg4.SetActive(true);
        }
    }
    //Pour remettre les points à 0 quand la scene reload

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Réinitialiser les points à zéro
        _infosNiveau._nbPoints = 0;
    } 

}

