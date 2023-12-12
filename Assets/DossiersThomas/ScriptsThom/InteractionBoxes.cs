using UnityEngine;

public class InteractionBoxes : MonoBehaviour
{
    [SerializeField] private GameObject _bighammer;
    [SerializeField] private GameObject _bighammerActive;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
        {
            // Si le joueur entre en collision avec le marteau et qu'il n'est pas encore pris
            if (other.CompareTag("Tool"))
            {
                _bighammerActive.SetActive(true); // Active l'élément UI correspondant au marteau
                Destroy(_bighammer);
                Destroy(gameObject);
            }
        }
}
