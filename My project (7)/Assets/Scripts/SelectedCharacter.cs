using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectedCharacter : MonoBehaviour
{
    private int i;
    private int currentChar;
    public GameObject[] All;
    [SerializeField] private Text coinsText1;
    public GameObject ArrowLeft;
    public GameObject ArrowRight;
    private int coins;
    public GameObject SelectButton;
    public GameObject SelectText;
    void Start()
    {
        coins = PlayerPrefs.GetInt("coins");
        if (PlayerPrefs.HasKey("CurrentCharacter"))
        {
            i = PlayerPrefs.GetInt("CurrentCharacter");
            currentChar = PlayerPrefs.GetInt("CurrentCharacter");

           
        }
        else
        {
            PlayerPrefs.SetInt("CurrentCharacter",i);
        }
        All[i].SetActive(true);

        SelectButton.SetActive(false);
        SelectText.SetActive(true);

        if (i > 0)
        {
            ArrowLeft.SetActive(true);

        }
        if(i == 4)
        {
            ArrowRight.SetActive(false);
        }
    }
    private void Update()
    {
        coinsText1.text = coins.ToString();
    }

    public void ArrowToRight()
    {
        if (i < All.Length)
        {
            if(i == 0)
            {
                ArrowLeft.SetActive(true);
            }
            All[i].SetActive(false);
            i++;
            All[i].SetActive(true);
            
            if(currentChar == i)
            {
                SelectButton.SetActive(false);
                SelectText.SetActive(true);
            }
            else
            {
                SelectButton.SetActive(true);
                SelectText.SetActive(false);
            }

            if(i + 1 == All.Length)
            {
                ArrowRight.SetActive(false);
            }
        }


    }

    public void ArrowToLeft()
    {
        if (i < All.Length)
        {
            All[i].SetActive(false);
            i--;
            All[i].SetActive(true);

            ArrowRight.SetActive(true);

            if (currentChar == i)
            {
                SelectButton.SetActive(false);
                SelectText.SetActive(true);
            }
            else
            {
                SelectButton.SetActive(true);
                SelectText.SetActive(false);
            }

            if (i == 0)
            {
                ArrowLeft.SetActive(false);
            }

        }


    }
    public void Select()
    {
        if (coins >= 100)
        {
            PlayerPrefs.SetInt("CurrentCharacter", i);
            currentChar = i;
            SelectButton.SetActive(false);
            SelectText.SetActive(true);
            coins -= 100;
            PlayerPrefs.SetInt("coins", coins);
        }

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }

    
}
