using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameReload : MonoBehaviour
{
    public ListeObjectifs listeObjectifs; // Assurez-vous de définir cette référence dans l'inspecteur Unity

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (listeObjectifs != null)
        {
            // Réinitialise les objectifs lorsque la scène est rechargée
            listeObjectifs.ReinitialiserObjectifs();
        }
    }
}
