using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;



public class Score : MonoBehaviour
{

    [SerializeField] public Text scoreText;
    public float score = 0 ;

    private void Update()
    {
        score += Time.deltaTime *3;

        scoreText.text = Mathf.Round(score).ToString();
    }
}
