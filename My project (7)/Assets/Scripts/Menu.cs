using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    [SerializeField] private Text coinsText;
    private void Start()
    {
        int coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
        Screen.SetResolution(400, 800, false);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
        Destroy(GameObject.Find("Audio Source"));
    }
    public void Store()
    {   
        SceneManager.LoadScene(2);
        Destroy(GameObject.Find("Audio Source"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
