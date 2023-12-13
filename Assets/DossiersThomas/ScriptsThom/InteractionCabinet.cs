using UnityEngine;

public class InteractionCabinet : MonoBehaviour
{
    [SerializeField] private GameObject _hammer;
    [SerializeField] private GameObject _hammerActive;
    [SerializeField] private ListeObjectifs _listeObjectifs;
    private bool _isHammerTaken = false;
    [SerializeField] private GameObject _crochetCanvas2;
    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Tool") && !_isHammerTaken)
            {
                _isHammerTaken = true;
                if (_listeObjectifs != null)
                {
                    _listeObjectifs.ObjectifAccompli("Marteau");
                }
                _hammerActive.SetActive(true); 
                Destroy(_hammer);
                Destroy(gameObject);
            }
        }
        public void ActiverImageObjectifAccompli(){
       _crochetCanvas2.SetActive(true);
       Debug.Log("tim");
    }
}
