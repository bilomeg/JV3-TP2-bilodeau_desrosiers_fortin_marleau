using UnityEngine;

public class InteractionPalette : MonoBehaviour
{
    [SerializeField] private GameObject _crowbar;
    [SerializeField] private GameObject _crowbarActive;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
        {
            // Si le joueur entre en collision avec le marteau et qu'il n'est pas encore pris
            if (other.CompareTag("Tool"))
            {
                _crowbarActive.SetActive(true); // Active l'élément UI correspondant au marteau
                Destroy(_crowbar);
                Destroy(gameObject);
            }
        }
}
