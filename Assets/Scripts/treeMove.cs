using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeMove : MonoBehaviour
{
    public GameObject enemy;
    public float randomX1,randomX2,randomY,randomR,randomspd;
    public float Spd = 1;
    int life,key;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life = PlayerPrefs.GetInt("life");
        
        treespeed();
    }

    private void treespeed()
    {
        key = PlayerPrefs.GetInt("key");
        if (PlayerPrefs.GetInt("life") > 0)
        {
            //Spd = enemy.GetComponent<Control>().hiz;
            transform.Translate(0, Time.deltaTime * (Spd * 2.5f), 0);
            randomR = Random.Range(1, 4);
            randomX1 = Random.Range(1.65f, 2.95f);
            randomX2 = Random.Range(-2.95f, -1.65f);
            randomY = Random.Range(-9f, -7f);

            transform.Translate(0, Time.deltaTime * (Spd * 2.5f), 0);

            

            if (transform.position.y > 6f)
            {
                randomspd = Random.Range(1f, 2.3f);
                Destroy(this.gameObject);
            }
            if (Time.deltaTime > 50 && Spd == 1)
            {
                Spd = Spd + 0.5f;
            }
            if (Time.deltaTime > 100 && Spd == 1.5f)
            {
                Spd = Spd + 0.5f;
            }
            if (Time.deltaTime > 250 && Spd == 2f)
            {
                Spd = Spd + 0.5f;
            }
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
        if (key == 0 && transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "tree")
        {
            Destroy(this.gameObject);
        }
    }

    
}
