using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionOutils : MonoBehaviour
{

    //==== Tools
    [SerializeField] private GameObject _hammer;
    [SerializeField] private GameObject _bighammer;
    [SerializeField] private GameObject _crowbar;


    //==== UI GameObjects
    [SerializeField] private GameObject _hammerActive;
    [SerializeField] private GameObject _bighammerActive;
    [SerializeField] private GameObject _crowbarActive;

    //==== Obstacles
    [SerializeField] private GameObject _boxes;
    [SerializeField] private GameObject _palette;
    [SerializeField] private GameObject _cabinet;

    
void OnTriggerEnter(Collider other)
{
    if(other.gameObject == _hammer)
    {
        _hammerActive.SetActive(true);
    }
}    


}
