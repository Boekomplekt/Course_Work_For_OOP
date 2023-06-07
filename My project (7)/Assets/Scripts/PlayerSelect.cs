using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{
    public GameObject[] characters;
    private int i;
    public GameObject pauseButton;
    private void Start()
    {
        i = 1;
        i = PlayerPrefs.GetInt("SelectPlayer");
        characters = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            characters[i] = transform.GetChild(i).gameObject;   
        }

        foreach (GameObject go in characters)
        {
            go.SetActive(false);
        }

        if (characters[i])
        {
            characters[i].SetActive(true);
        }
    }

    public void ArrowToLeft()
    {
        characters[i].SetActive(false);
        i--;
        if (i < 0)
        {
            i = characters.Length - 1;
        }

        characters[i].SetActive(true);

    }
    public void ArrowToRight()
    {
        characters[i].SetActive(false);
        i++;
        if (i == characters.Length)
        {
            i = 0;
        }

        characters[i].SetActive(true);

    }
    public void StartScene()
    {
        PlayerPrefs.SetInt("SelectPlayer", i);
        SceneManager.LoadScene(1);
    }
}
