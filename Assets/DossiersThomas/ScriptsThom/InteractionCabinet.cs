using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCabinet : MonoBehaviour
{
    [SerializeField] private GameObject _hammer;
    [SerializeField] private GameObject _hammerActive;
    [SerializeField] private ListeObjectifs _listeObjectifs;
    private bool _isHammerTaken = false;
    [SerializeField] private GameObject _crochetCanvas2;
     public bool IsHammerTaken()
    {
        return _isHammerTaken;
    }
    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Tool") && !_isHammerTaken)
            {
                _isHammerTaken = true;
                if (_listeObjectifs != null)
                {
                    _listeObjectifs.ObjectifAccompli("Marteau");
                    _crochetCanvas2.SetActive(true);
                }
                _hammerActive.SetActive(true); 
                Destroy(_hammer);
                Destroy(gameObject);
            }
        }
      
}
