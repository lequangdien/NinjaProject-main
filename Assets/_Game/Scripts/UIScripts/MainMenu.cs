using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private bool isVictoryUIActive=true;

  [SerializeField]  public GameObject UIVictory;
   // public static MainMenu instance;
    public void StartGameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void WinGame()
    {
        if (!isVictoryUIActive) {
            SceneManager.LoadScene("MenuScene");
            UIVictory.SetActive(false);
        isVictoryUIActive =false;}
        else
        { 
            UIVictory.SetActive(true);
            isVictoryUIActive = true;
        }
    }
   
   

}
