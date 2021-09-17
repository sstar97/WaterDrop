using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreTimer : MonoBehaviour
{
    public GameObject txt;

    
    public float score;
    public int scr,hScore,coin, health;
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("money"));
        score = 0;
        hScore= PlayerPrefs.GetInt("High Score");
        coin = PlayerPrefs.GetInt("money");
        Debug.Log(coin);
    }

    
    void Update()
    {
        

        if (PlayerPrefs.GetInt("life") > 0)
        {
            timerScore();
            highScore();
            
            if(PlayerPrefs.GetInt("moneySay")== 1)
            {
                coin += scr;
                PlayerPrefs.SetInt("money", coin);
                Debug.Log(coin);
                PlayerPrefs.SetInt("moneySay", 0);
            }
        }
        
    }

    private void timerScore()
    {
        score += Time.deltaTime;
        if (score % 25 == 0)
        {
            score += (Time.deltaTime*2);
        }
        scr = Mathf.RoundToInt(score);
        txt.GetComponent<UnityEngine.UI.Text>().text = scr.ToString();

    }

    private void highScore()
    {
        
        if (scr > hScore)
        {
            PlayerPrefs.SetInt("High Score", scr);
        }
    }
}
