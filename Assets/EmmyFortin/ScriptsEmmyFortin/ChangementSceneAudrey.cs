using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementSceneAudrey : MonoBehaviour
{
   [SerializeField] private ListeObjectifs _listeObjectifs;
     [SerializeField] private GameObject _crochetAudrey2;
   
     [SerializeField] private GameObject _pastille;

     public void CleSerrure(){
         _listeObjectifs.ObjectifAccompli("AudreyCle");
             _crochetAudrey2.SetActive(true);
             _pastille.SetActive(true);
     }
}
