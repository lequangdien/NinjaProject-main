using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VictoryUI : MonoBehaviour
{
   public static VictoryUI Instance;
  
    [SerializeField] public GameObject victoryUI;
   

    public void VictoryUi()
    {
        victoryUI.SetActive(true);
    }
}
