using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text coinText;
    public static UIManager instance;
   
    private void Awake()
    {
        instance = this;
    }
    public void SetCoin(int coin)
    {
        coinText.text = coin.ToString();
    }
    public void ChonLevel()
    {
        Scene curentScene = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(curentScene);

        SceneManager.LoadScene(1);
    }
}
