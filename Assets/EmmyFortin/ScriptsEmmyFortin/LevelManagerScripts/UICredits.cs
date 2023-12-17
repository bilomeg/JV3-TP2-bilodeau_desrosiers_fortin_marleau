using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class UICredits : MonoBehaviour
{
       [SerializeField] Button _accueil;

    private LevelManager _levelManager;
    [SerializeField] private TMP_Text _texteNbPoints;
    [SerializeField] private InfosNiveau _infosNiveau;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
        _accueil.onClick.AddListener(AllerAccueil);
        _texteNbPoints.text = _infosNiveau._nbPoints.ToString() + " $";
      
    }
 private void AllerAccueil()
    {
      _levelManager.LoadMainMenu();
    }
    
}
