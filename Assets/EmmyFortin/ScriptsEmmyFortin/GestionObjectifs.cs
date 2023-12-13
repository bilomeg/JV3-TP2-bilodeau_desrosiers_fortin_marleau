using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionObjectifs : MonoBehaviour
{
    public ListeObjectifs listeObjectifs; // Référence à votre ScriptableObject
[SerializeField]
  private Animator _animationAscenceur;

    void Update()
    {
        Debug.Log("chat");
        // Vérifier si tous les objectifs sont accomplis
        if (SontTousObjectifsAccomplis())
        {
          
            // Jouer l'animation
            if (_animationAscenceur != null)
            {  Debug.Log("minou");
                //animator.SetTrigger("ObjectifsAccomplis"); // Remplacez "ObjectifsAccomplis" par le nom de votre trigger d'animation
                _animationAscenceur.Play("AscenceurOuvre");
            }
        }
    }

    bool SontTousObjectifsAccomplis()
    {
        foreach (ListeObjectifs.Objectif objectif in listeObjectifs.objectifs)
        {
            if (!objectif._estAccompli)
            {
                return false; // S'il y a au moins un objectif non accompli, retourner false
            }
        }
        return true; // Tous les objectifs sont accomplis
    }
}

