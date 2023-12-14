using System.Collections;
using System.Linq;
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
     public bool TousLesObjectifsAccomplis()
    {
   
        // Vérifie si tous les objectifs sont accomplis
        return objectifs.All(o => o._estAccompli);
        
    }
    public void ReinitialiserObjectifs()
    {
        // Réinitialise tous les objectifs à non accomplis
        foreach (Objectif objectif in objectifs)
        {
            objectif._estAccompli = false;
        }
    }
   
}
