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
   private InteractionPalette _interactionPalette;
   private InteractionCabinet _interactionCabinet;

  
    // Méthode pour assigner la référence à _interactionPalette
    public void AssignerInteractionPalette(InteractionPalette interactionPalette)
    {
        _interactionPalette = interactionPalette;
    }

    // Méthode pour assigner la référence à _interactionCabinet
    public void AssignerInteractionCabinet(InteractionCabinet interactionCabinet)
    {
        _interactionCabinet = interactionCabinet;
    }

    public void ObjectifAccompli(string _nomObjectif)
    {
        Objectif objectif = objectifs.Find(o => o._nomObjectif == _nomObjectif);
        if (objectif != null)
        {
            objectif._estAccompli = true;
        }
    }
   
}
