using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanneau : MonoBehaviour
{
    [SerializeField]
  private GameObject _switch1On;

  [SerializeField]
  private GameObject _switch1Off;

[SerializeField]
  private GameObject _switch2On;

 [SerializeField]
  private GameObject _switch2Off;
  private bool _toggleSwitch1;
private bool _toggleSwitch2;

public bool _courantOn;
   




   [SerializeField]
  private GameObject _switchOn;

  [SerializeField]
  private GameObject _switchOff;

[SerializeField]
  private GameObject _lumiereDuLobby;

  private bool _toggleSwitch;
  public void Switch1OnOff()
  {
    
    if (_toggleSwitch1 == false)
    {
      Debug.Log("text");
      _switch1On.SetActive(true);
      _switch1Off.SetActive(false);
      _toggleSwitch1 = true;

CourantCheck();
  
    }
     else
    {
      
      _switch1On.SetActive(false);
      _switch1Off.SetActive(true);
      _toggleSwitch1 = false;

  

    }
    }
    public void Switch2OnOff(){
       if(_toggleSwitch2 == false)
    {
      _switch2On.SetActive(true);
      _switch2Off.SetActive(false);
      _toggleSwitch2 = true;
      CourantCheck();
    }
      else
    {
      
      _switch2On.SetActive(false);
      _switch2Off.SetActive(true);
      _toggleSwitch2 = false;

  

    }
    
    }
    public void CourantCheck()
{
    if (_toggleSwitch1 && _toggleSwitch2)
        {
            Debug.Log("all0");
            _courantOn = true;
         
        }
        else
        {
            _courantOn = false;
       
        }
}

   public void AllumerLumiere(){
    if(_toggleSwitch == false && _courantOn ==true){
        Debug.Log("yes");
         _switchOn.SetActive(true);
      _switchOff.SetActive(false);
      _toggleSwitch = true;
      _lumiereDuLobby.SetActive(true);
      //_sonInterupteur.Play();
    }
    else{
              _switchOn.SetActive(false);
      _switchOff.SetActive(true);
      _toggleSwitch = false;
      _lumiereDuLobby.SetActive(false);
      //_sonInterupteur.Play();
    }
   } 
  
}
