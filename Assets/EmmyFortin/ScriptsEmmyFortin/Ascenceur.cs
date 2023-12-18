using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascenceur : MonoBehaviour
{
    [SerializeField] private ListeObjectifs _objectifsNiveau;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    
    }

  void Update(){
    if(_objectifsNiveau.TousLesObjectifsAccomplis()){
        OuvrePorteAscenceur();
    }
    
  }
    public void OuvrePorteAscenceur(){
        _animator.SetBool("ActionFini", true);

    }
}
