using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameImage : MonoBehaviour
{
    private int i;
    private int currentChar;
    public GameObject[] All;
 
    void Start()
    {
        if (PlayerPrefs.HasKey("CurrentCharacter"))
        {
            i = PlayerPrefs.GetInt("CurrentCharacter");
            currentChar = PlayerPrefs.GetInt("CurrentCharacter");


        }
        else
        {
            PlayerPrefs.SetInt("CurrentCharacter", i);
        }
        All[i].SetActive(true);

    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }


}
