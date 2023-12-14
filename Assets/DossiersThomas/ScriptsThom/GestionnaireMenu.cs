using UnityEngine;
using UnityEngine.InputSystem;

public class GestionnaireMenu : MonoBehaviour
{
    [SerializeField] private GameObject _interfaceAudio;
    
    private void OnMenu(InputValue value)
    {
        if(_interfaceAudio.activeSelf == false)
        {
            _interfaceAudio.SetActive(true);
        }    
    }

    public void CloseMenu()
    {
        _interfaceAudio.SetActive(false);
    }
}
