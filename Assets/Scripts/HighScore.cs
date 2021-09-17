using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text hscoreTxt;
    public int scr;

    private void Start()
    {
        scr = PlayerPrefs.GetInt("High Score");
    }

    // Update is called once per frame
    void Update()
    {
        hscoreTxt.text= Convert.ToString(scr);
    }
}
