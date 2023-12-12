using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortePanneau : MonoBehaviour
{

[SerializeField]
  private Animator _animationPanneau;

  private bool _panneauOuvert;


 void Start()
{
    _animationPanneau = gameObject.GetComponent<Animator>();
}
  public void PanneauOuvertFermer()
  {
    
    if (_panneauOuvert == false)
    {
      _animationPanneau.Play("PorteOuvre");
      _panneauOuvert = true;
      Debug.Log("hello");
     
    
  
    }
    else
    {
      
     
      _panneauOuvert = false;
      Debug.Log("bye");
      
      

    }
  }
}
