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
    [SerializeField] private float _tempsQuiReste;

    // Référence aux scriptables objects
    [SerializeField] private InfosNiveau _infosDuNiveau;
  
    
    //Pour déterminer si le temps est écoule 
    private bool _tempsEstEcoule = false;
   
   


    
    void Update()
    {
        //Si le temps n'est pas fini on le calcul sinon on ne le calcul pas 
        if(! _tempsEstEcoule){
           CalculTemps(); 
        }
        
    }
   
   void CalculTemps(){

    _tempsQuiReste -= Time.deltaTime; 
    AfficherTemps(_tempsQuiReste);

   // Si le temps est fini la valeur de la variable devient true et on appel le ChangementDeScene
   /* if(_tempsQuiReste <= 0f){
          
        _tempsEstEcoule = true;
        _tempsQuiReste = 0f;
          if (_infosJoueurs._nbPoints >= _infosDuNiveau._nbDePointsRequis)
        {
            // Tous les objets ont été ramassés, déclencher la victoire.
            Victoire();
        }
        else
        {
            // Tous les objets n'ont pas été ramassés, déclencher la défaite.
            Defaite();
        }
        
    }*/

   }
   
    //Pour afficher le temps du timer qui avance 
    void AfficherTemps(float temps){

    temps +=1;

    float minutes = Mathf.FloorToInt(temps/60);
    float secondes = Mathf.FloorToInt(temps % 60);

    _tempsTexte.text = string.Format("{0:00}:{1:00}",minutes,secondes);
    
    _infosDuNiveau._tempsDeJeu = _tempsTexte.text;

   }
    
    //Pour déclancher la victoire
   /* private void Victoire(){

     ChangementDeScene();   
    _infosDuNiveau._victoirePartie = true;
    _infosDuNiveau._defaitePartie = false;

    }

    //Pour déclancher la défaite 
    private void Defaite(){
    ChangementDeScene(); 
    //Change la valeur de la variable de l'infoNiveau qui permet de déterminer si la partie est gagné ou perdu ce qui determine quel canvas entre le canvas de défaite et victoire est affiché   
    _infosDuNiveau._victoirePartie = false;
    _infosDuNiveau._defaitePartie = true;
    }*/
    
    //Pour le changement de scene
    private void ChangementDeScene(){

     int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
     SceneManager.LoadScene(nextSceneIndex); 

    }
}


