using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneSceneFin : MonoBehaviour
{
    private LevelManager _levelManager;


    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }


public void AllerSceneCredits(){
    _levelManager.LoadAsyncScene(LevelManager.Scene.Credits);
    
}
 /*private void OnTriggerEnter(Collider other)
 {
    _levelManager.LoadAsyncScene(LevelManager.Scene.Credits);
 }*/
}
