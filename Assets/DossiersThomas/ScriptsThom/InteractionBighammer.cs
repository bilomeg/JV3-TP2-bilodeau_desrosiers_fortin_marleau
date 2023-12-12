using UnityEngine;

public class InteractionBighammer : MonoBehaviour
{
    [SerializeField] private GameObject _bighammerActive;

    private bool _isTaken = false;

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && !_isTaken)
            {
                _bighammerActive.SetActive(true); 
                _isTaken = true; 
            } 
        }
}
