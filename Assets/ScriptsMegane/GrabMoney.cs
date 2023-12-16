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

    [SerializeField] private int _money = 100;
    [SerializeField] private int _bijoux = 250;
    [SerializeField] private int _valise = 500;
    [SerializeField] private int _lignots = 1000;

    private bool isGrabbed = false;
  void Update()
    {
        AfficherPoints();
    }
    public void AfficherPoints(){
       
       _texteNbPoints.text = _infosNiveau._nbPoints.ToString();
         
    }
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

