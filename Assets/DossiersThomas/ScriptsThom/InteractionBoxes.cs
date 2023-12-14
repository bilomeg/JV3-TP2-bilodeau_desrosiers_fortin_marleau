using UnityEngine;

public class InteractionBoxes : MonoBehaviour
{
    [SerializeField] private GameObject _bighammer;
    [SerializeField] private GameObject _bighammerActive;
    // Start is called before the first frame update
    [SerializeField] private ListeObjectifs _listeObjectifs;
    private bool _isMassueTaken = false;
    [SerializeField]
  private Animator _animationAcsneceur;

    [SerializeField] private GameObject _crochetCanvas3;
     void Start()
{
    _animationAcsneceur = gameObject.GetComponent<Animator>();
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
