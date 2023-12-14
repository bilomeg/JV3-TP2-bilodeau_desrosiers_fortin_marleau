using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBoxes : MonoBehaviour
{
    [SerializeField] private Animator _animationAscenceur;
    [SerializeField] private GameObject _bighammer;
    [SerializeField] private GameObject _bighammerActive;
    // Start is called before the first frame update
    [SerializeField] private ListeObjectifs _listeObjectifs;
    private bool _isMassueTaken = false;



    [SerializeField] private GameObject _crochetCanvas3;
 public bool IsMassueTaken()
    {
        return _isMassueTaken;
    }
    private void OnTriggerEnter(Collider other)
        {
            // Si le joueur entre en collision avec le marteau et qu'il n'est pas encore pris
            if (other.CompareTag("Tool") && ! _isMassueTaken)
            {
                _isMassueTaken = true; 
                if(_listeObjectifs != null){
                    _listeObjectifs.ObjectifAccompli("Massue");
                    _crochetCanvas3.SetActive(true);
                 
                }
                
                _bighammerActive.SetActive(true); // Active l'élément UI correspondant au marteau
                Destroy(_bighammer);
                Destroy(gameObject); 
                 
            }
        }
     
}
