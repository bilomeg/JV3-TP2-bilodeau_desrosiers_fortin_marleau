using UnityEngine;

public class InteractionDebut : MonoBehaviour
{

    [SerializeField] private GameObject _explications;
    [SerializeField] private GameObject _interfaceJeu;
    

    // Start is called before the first frame update
    void Start()
    {
        if(_explications.activeSelf == false)
        {
            MontreExplications();
            Invoke("CacheExplications", 8f);
            Invoke("MontreInterfaceJeu", 8f);
        }
    }

    void MontreExplications()
    {
        _explications.SetActive(true);
    }

    void CacheExplications()
    {
        if(_explications.activeSelf == true)
        {
            _explications.SetActive(false);
        } 
    }

    void MontreInterfaceJeu()
    {
        _interfaceJeu.SetActive(true);
    }
}
