using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivationScript : MonoBehaviour
{
    [SerializeField]
    private XRSocketInteractor xrSocketInteractor;

    [SerializeField]
    private GameObject pastilleChangementScene;

    private void Start()
    {
        // Assurez-vous que le XRSocketInteractor est assigné.
        if (xrSocketInteractor == null)
        {
            Debug.LogError("Veuillez assigner XRSocketInteractor dans l'inspecteur.");
        }

        // Assurez-vous que le GameObject est assigné.
        if (pastilleChangementScene == null)
        {
            Debug.LogError("Veuillez assigner le GameObject dans l'inspecteur.");
        }

        // Désactivez le GameObject au début du jeu.
        pastilleChangementScene.SetActive(false);
    }

    private void OnEnable()
    {
        // S'abonner à l'événement selectEntered de XRSocketInteractor.
        xrSocketInteractor.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnDisable()
    {
        // Désabonner de l'événement selectEntered de XRSocketInteractor.
        xrSocketInteractor.selectEntered.RemoveListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Lorsqu'un objet entre dans le XRSocketInteractor, activer le GameObject.
        pastilleChangementScene.SetActive(true);
    }
}
