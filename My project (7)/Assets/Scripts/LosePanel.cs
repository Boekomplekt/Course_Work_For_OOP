using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    [SerializeField] Text recordText;
   
    public void Start()
    {
        int LastRunScore = PlayerPrefs.GetInt("LastRunScore");
        int recordScore = PlayerPrefs.GetInt("recordScore");
        if (LastRunScore > recordScore)
        {
            recordScore = LastRunScore;
            PlayerPrefs.SetInt("recordScore", recordScore);
            recordText.text = recordScore.ToString();
        }
        else
        {
            recordText.text = recordScore.ToString();
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
