using UnityEngine;

public class InteractionCabinet : MonoBehaviour
{
    [SerializeField] private GameObject _hammer;
    [SerializeField] private GameObject _hammerActive;

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Tool"))
            {
                _hammerActive.SetActive(true); 
                Destroy(_hammer);
                Destroy(gameObject);
            }
        }
}
