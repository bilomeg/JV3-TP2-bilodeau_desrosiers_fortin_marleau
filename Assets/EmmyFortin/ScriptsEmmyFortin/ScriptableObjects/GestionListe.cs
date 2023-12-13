using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionListe : MonoBehaviour
{
     [SerializeField] private ListeObjectifs _listeObjectifs;
    [SerializeField] private InteractionPalette _interactionPalette;
    [SerializeField] private InteractionCabinet _interactionCabinet;
    [SerializeField] private InteractionBoxes _interactionBoxes;

    void Start()
    {
        // Initialiser la référence au script InteractionPalette dans ListeObjectifs
        _listeObjectifs.InitialiserInteractionPalette(_interactionPalette);
        _listeObjectifs.InitialiserInteractionCabinet(_interactionCabinet);
        _listeObjectifs.InitialiserInteractionBoxes(_interactionBoxes);
        Debug.Log("hello");
    }
}
