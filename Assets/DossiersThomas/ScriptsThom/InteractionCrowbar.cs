using UnityEngine;

public class InteractionCrowbar : MonoBehaviour
{
    [SerializeField] private GameObject _crowbarActive;

    private bool _isTaken = false;

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && !_isTaken)
            {
                _crowbarActive.SetActive(true); 
                _isTaken = true; 
            } 
        }
}
