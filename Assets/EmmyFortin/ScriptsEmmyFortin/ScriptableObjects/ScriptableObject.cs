using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListeObjectifs", menuName = "ScriptableObject/NouveauxObjectifs", order = 1)]
public class ListeObjectifs : ScriptableObject
{

 [System.Serializable]
    public class Objectif
    {
        public string _nomObjectif;
        public bool _estAccompli;
    }
   public List<Objectif> objectifs = new List<Objectif>();
   

    public void ObjectifAccompli(string _nomObjectif)
    {
        Objectif objectif = objectifs.Find(o => o._nomObjectif == _nomObjectif);
        if (objectif != null)
        {
            objectif._estAccompli = true;
        }
    }
   
}
