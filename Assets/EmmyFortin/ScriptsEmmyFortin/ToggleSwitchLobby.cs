using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwitchLobby : MonoBehaviour
{
   [SerializeField]
  private GameObject _switchOn;

  [SerializeField]
  private GameObject _switchOff;

[SerializeField]
  private GameObject _lumiereDuLobby;

  private bool _toggleSwitch;

  public void LumiereOnOff()
  {
    
    if (_toggleSwitch == false)
    {
      
      _switchOn.SetActive(true);
      _switchOff.SetActive(false);
      _toggleSwitch = true;
      _lumiereDuLobby.SetActive(true);

  
    }
    else
    {
      
      _switchOn.SetActive(false);
      _switchOff.SetActive(true);
      _toggleSwitch = false;
      _lumiereDuLobby.SetActive(false);


    }
  }
}