using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Control2 : MonoBehaviour
{
    public GameObject bgBir;
    public GameObject bgIki;

    Rigidbody2D fizikBir;
    Rigidbody2D fizikIki;

    float uzunluk = 0;
    public float hiz = 0;
    public float score;
    public int scr;
    void Start()
    {
        PlayerPrefs.SetInt("life", 3);
        fizikBir = bgBir.GetComponent<Rigidbody2D>();
        fizikIki = bgIki.GetComponent<Rigidbody2D>();

        fizikBir.velocity = new Vector2(0, hiz);
        fizikIki.velocity = new Vector2(0, hiz);

        uzunluk = bgBir.GetComponent<BoxCollider2D>().size.x;
    }

    
    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("life") > 0)
        {
            fizikBir.velocity = new Vector2(0, hiz);
            fizikIki.velocity = new Vector2(0, hiz);
            repeat();
            speedUp();
            scorePnt();
        }
        else
        {
            fizikBir.velocity = new Vector2(0, 0);
            fizikIki.velocity = new Vector2(0, 0);
        }
    }

    private void repeat()
    {
        if (bgBir.transform.position.y >= uzunluk)
        {
            bgBir.transform.position += new Vector3(0, -uzunluk * 2);
        }

        if (bgIki.transform.position.y >= uzunluk)
        {
            bgIki.transform.position += new Vector3(0, -uzunluk * 2);
        }
    }

    private void speedUp()
    {
        if (scr % 25 == 0 && scr>1)
        {
            hiz += 0.5f;
            fizikBir.velocity = new Vector2(0, hiz);
            fizikIki.velocity = new Vector2(0, hiz);
            score += 1;
        }
    }

    private void scorePnt()
    {
        score += Time.deltaTime;
        scr = Mathf.RoundToInt(score);
    }
}
