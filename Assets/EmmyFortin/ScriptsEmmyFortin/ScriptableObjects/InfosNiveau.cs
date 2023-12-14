using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Pour créer le scriptable object niveau
[CreateAssetMenu(fileName="InfosNiveau", menuName ="SO/InfosNouveauNiveau")]
public class InfosNiveau : ScriptableObject
{
    //Variable du scriptable object niveau
    [SerializeField] public string _tempsDeJeu;
    //Variable qui dit si on gagne la partie
    public bool _defaitePartie;
    public bool _victoirePartie;


}
