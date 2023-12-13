using UnityEngine;

public class InteractionPalette : MonoBehaviour
{
    [SerializeField] private GameObject _crowbar;
    [SerializeField] private GameObject _crowbarActive;

    [SerializeField] private ListeObjectifs _listeObjectifs;
      private bool _isCrowbarTaken = false;
      [SerializeField] private GameObject _crochetCanvas;
    // Start is called before the first frame update

 private void OnTriggerEnter(Collider other)
    {
        // Si le joueur entre en collision avec le marteau et qu'il n'est pas encore pris
        if (other.CompareTag("Tool") && !_isCrowbarTaken)
        {
            _isCrowbarTaken = true;

            // Activer l'élément UI correspondant au marteau (à condition que ce soit un objectif)
            if (_listeObjectifs != null)
            {
                _listeObjectifs.ObjectifAccompli("CrowBar");
                _crochetCanvas.SetActive(true);
                Debug.Log("dodo");
            }

            _crowbarActive.SetActive(true); // Activer l'élément UI correspondant au marteau
            Destroy(_crowbar);
            Destroy(gameObject);
        }
    }

}
