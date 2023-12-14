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
  public void Switch1OnOff()
  {
    
    if (_toggleSwitch1 == false)
    {
      Debug.Log("text");
      _switch1On.SetActive(true);
      _switch1Off.SetActive(false);
      _toggleSwitch1 = true;


  
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
    }
      else
    {
      
      _switch2On.SetActive(false);
      _switch2Off.SetActive(true);
      _toggleSwitch2 = false;

  

    }
    
    }
    
  
}
