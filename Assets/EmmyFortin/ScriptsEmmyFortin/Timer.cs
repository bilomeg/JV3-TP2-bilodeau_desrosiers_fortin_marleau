using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Référence au texte du timer
    [SerializeField] private TMP_Text _tempsTexte;
    //Variable qui affichera le temps 
  private bool _tempsJeuFini = false;

    // Référence aux scriptables objects
    [SerializeField] private InfosNiveau _infosDuNiveau;
  
  [SerializeField]private ZoneSceneFin _zoneFinScene;
   


 void Awake()
 {
    
 //_infosDuNiveau.init();
 }


    
    void Update()
    {
      
            CalculTemps(); 

           

    
        
    }
   
   void CalculTemps(){

    _infosDuNiveau._tempsEcoule -= Time.deltaTime; 
    if(_tempsTexte != null){
        AfficherTemps(_infosDuNiveau._tempsEcoule);
    }
     if (_infosDuNiveau._tempsEcoule<= 0f){
        Debug.Log($"h");
        _tempsJeuFini = true;
        _infosDuNiveau._tempsEcoule =0f;
         _zoneFinScene.AllerSceneCredits();

       
    }
 


   }
   
    //Pour afficher le temps du timer qui avance 
    void AfficherTemps(float temps){

    temps +=1;

    float minutes = Mathf.FloorToInt(temps/60);
    float secondes = Mathf.FloorToInt(temps % 60);

    _tempsTexte.text = string.Format("{0:00}:{1:00}",minutes,secondes);
    
 
 
   }

}


