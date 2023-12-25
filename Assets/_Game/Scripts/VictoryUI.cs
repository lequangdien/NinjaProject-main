using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryUI : MonoBehaviour
{
    public string newSceneName = "MenuScene";
    public string newSceneName2 = "SceneOne";
    public string resourceName ="Level2";
    public void BackMenu()
    {
        Scene curentScene = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(curentScene);

        SceneManager.LoadScene(newSceneName);
    }
    public void LoadMap()
    {

        // Load t�i nguy�n theo t�n
        GameObject resourceObject = Resources.Load<GameObject>(resourceName);

        if (resourceObject != null)
        {
            // Instantiate ho?c s? d?ng t�i nguy�n ?� load t?i ?�y
            Instantiate(resourceObject, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Kh�ng th? load t�i nguy�n: " + resourceName);
        }
    }
    public void LoadPlayer()
    {
        Scene curentScene = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(curentScene);

        SceneManager.LoadScene(3);
    }

}
