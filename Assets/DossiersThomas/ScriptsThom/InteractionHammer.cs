using UnityEngine;

public class InteractionHammer : MonoBehaviour
{
    [SerializeField] private GameObject _hammerActive;

    private bool _isTaken = false;

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && !_isTaken)
            {
                _hammerActive.SetActive(true); 
                _isTaken = true; 
            } 
        }

}
