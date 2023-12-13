using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListeObjectifs", menuName = "ScriptableObject/ListeObjectifs", order = 1)]
public class ListeObjectifs : ScriptableObject
{
 public List<GameObject> objectifsAFaire = new List<GameObject>();

    public void AddObjectifsASuivre(GameObject obj)
    {
        objectifsAFaire.Add(obj);
    }

    public bool SiObjetEstDetruit(GameObject obj)
    {
        return !objectifsAFaire.Contains(obj);
    }
}
