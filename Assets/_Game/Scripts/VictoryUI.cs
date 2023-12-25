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

        // Load tài nguyên theo tên
        GameObject resourceObject = Resources.Load<GameObject>(resourceName);

        if (resourceObject != null)
        {
            // Instantiate ho?c s? d?ng tài nguyên ?ã load t?i ?ây
            Instantiate(resourceObject, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Không th? load tài nguyên: " + resourceName);
        }
    }
    public void LoadPlayer()
    {
        Scene curentScene = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(curentScene);

        SceneManager.LoadScene(3);
    }

}
