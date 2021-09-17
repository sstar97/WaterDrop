using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeMove : MonoBehaviour
{

    public float Spd = 3f;
    public float timer;
    int life, key;
    string name;
    
    void Start()
    {
        Spd = 3;
        name = this.gameObject.GetComponent<SpriteRenderer>().sprite.name;
    }

    // Update is called once per frame
    void Update()
    {
        key = PlayerPrefs.GetInt("key");
        life = PlayerPrefs.GetInt("life");
        if ((key == 0 && transform.position.x < -4)|| (key == 0 && transform.position.x > 4))
        {
            Destroy(this.gameObject);
        }
        if (life > 0)
        {
            BeeSpeed();
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
        life = PlayerPrefs.GetInt("life");
    }

    private void BeeSpeed()
    {
        timer += Time.deltaTime;
        key = PlayerPrefs.GetInt("key");
        if (PlayerPrefs.GetInt("life") > 0)
        {
            if (name == "beeL")
            {
                transform.Translate(-Time.deltaTime * (Spd * 1.2f), 0, 0);
                transform.Translate(0, Time.deltaTime * (Spd * 0.4f), 0);
                if (timer <= 1)
                {
                    transform.Rotate(0, 0, Time.deltaTime * -40);
                }
                else if (timer <= 2)
                {
                    transform.Rotate(0, 0, Time.deltaTime * 40);
                    if (timer == 2)
                    {
                        timer = 0;
                    }
                }

            }
            else if (name == "bee2")
            {
                transform.Translate(Time.deltaTime * (Spd * 1.2f), 0, 0);
                transform.Translate(0, Time.deltaTime * (Spd * 0.4f), 0);
                if (timer <= 1)
                {
                    transform.Rotate(0, 0, Time.deltaTime * 40);
                }
                else if (timer <= 2)
                {
                    transform.Rotate(0, 0, Time.deltaTime * -40);
                    if (timer == 2)
                    {
                        timer = 0;
                    }
                }

            }

            if (transform.position.x > 7f || transform.position.y > 7f || transform.position.x < -7f)
            {
                Destroy(this.gameObject);
            }
            if ((key == 0 && transform.position.x > 4) || (key == 0 && transform.position.x < -4))
            {
                Destroy(this.gameObject);
            }


            if (Time.deltaTime > 50 && Spd == 3)
            {
                Spd = Spd + 0.5f;
            }
            if (Time.deltaTime > 100 && Spd == 3.5f)
            {
                Spd = Spd + 0.5f;
            }
            if (Time.deltaTime > 250 && Spd == 4f)
            {
                Spd = Spd + 0.5f;
            }
        }
    }

}
