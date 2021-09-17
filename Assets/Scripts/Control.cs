using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject BackgroundBır;
    public GameObject BackgroundIkı;

    Rigidbody2D fizikBir;
    Rigidbody2D fizikIki;

    float uzunluk = 0;

    public float hiz = 3;
    public float score;
    public int scr;
    public float spd2;
    void Start()
    {
        PlayerPrefs.SetInt("life", 3);
        fizikBir = BackgroundBır.GetComponent<Rigidbody2D>();
        fizikIki = BackgroundIkı.GetComponent<Rigidbody2D>();

        fizikBir.velocity = new Vector2(0, hiz);
        fizikIki.velocity = new Vector2(0, hiz);

        uzunluk = BackgroundBır.GetComponent<BoxCollider2D>().size.x;
    }

    
    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("life") >= 1)
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
        if (BackgroundBır.transform.position.y >= uzunluk)
        {
            BackgroundBır.transform.position += new Vector3(0, -uzunluk * 2);
        }

        if (BackgroundIkı.transform.position.y >= uzunluk)
        {
            BackgroundIkı.transform.position += new Vector3(0, -uzunluk * 2);
        }
    }

    public void speedUp()
    {
        if (scr % 25 == 0 && scr > 1)
        {
            hiz += 0.2f;
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
