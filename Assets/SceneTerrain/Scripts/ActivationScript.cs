using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivationScript : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor xrSocketInteractor;
    [SerializeField] private GameObject pastilleChangementScene;
    [SerializeField] private GameObject clef;

    private void Start()
    {
        if (xrSocketInteractor == null)
        {
            Debug.LogError("Veuillez assigner XRSocketInteractor dans l'inspecteur.");
        }

        if (pastilleChangementScene == null)
        {
            Debug.LogError("Veuillez assigner le GameObject dans l'inspecteur.");
        }

        if (clef == null)
        {
            Debug.LogError("Veuillez assigner le GameObject de la clé dans l'inspecteur.");
        }

        pastilleChangementScene.SetActive(false);
    }

    private void OnEnable()
    {
        xrSocketInteractor.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnDisable()
    {
        xrSocketInteractor.selectEntered.RemoveListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactable.gameObject == clef)
        {
            pastilleChangementScene.SetActive(true);
        }
    }
}
