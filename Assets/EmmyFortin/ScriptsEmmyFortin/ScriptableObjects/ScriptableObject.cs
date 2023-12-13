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
   private InteractionBoxes _interactionBoxes;

   // Assigner la référence au script InteractionPalette lors de l'initialisation
    public void InitialiserInteractionPalette(InteractionPalette interactionPalette)
    {
        _interactionPalette = interactionPalette;
    }
    public void InitialiserInteractionCabinet(InteractionCabinet interactionCabinet)
    {
        _interactionCabinet = interactionCabinet;
    }
    public void InitialiserInteractionBoxes(InteractionBoxes interactionBoxes)
    {
        _interactionBoxes = interactionBoxes;
    }
public void ObjectifAccompli(string _nomObjectif)
    {
        Objectif objectif = objectifs.Find(o => o._nomObjectif == _nomObjectif);
        if (objectif != null)
         {
            objectif._estAccompli = true;
            Debug.Log("Objectif accompli : " + _nomObjectif);

            // Appeler la fonction pour activer l'image correspondante à l'objectif accompli
            if (_interactionPalette != null)
            {
                _interactionPalette.ActiverImageObjectifAccompli();
            }
             // Appeler la fonction pour activer l'image correspondante à l'objectif accompli
            if (_interactionCabinet != null)
            {
                _interactionCabinet.ActiverImageObjectifAccompli();
            }
             // Appeler la fonction pour activer l'image correspondante à l'objectif accompli
            if (_interactionBoxes != null)
            {
                _interactionBoxes.ActiverImageObjectifAccompli();
            }
        }
    }  
   
}
