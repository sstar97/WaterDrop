using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public GameObject enemy;
    
    public float Spd = 3;
    public float timer;
    int life,key;
    void Start()
    {
        Spd = 3;
    }

    // Update is called once per frame
    void Update()
    {
        life = PlayerPrefs.GetInt("life");
        if (life > 0 )
        {
            EnemySpeed();
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
        
    }

    private void EnemySpeed()
    {
        key = PlayerPrefs.GetInt("key");
        timer += Time.deltaTime;
        transform.Translate(0, Time.deltaTime * (Spd / 2), 0);
        if ((key == 0 && transform.position.y < -4) || (key == 0 && transform.position.y == -6.2f))
        {
            Destroy(this.gameObject);
        }
        //transform.Rotate(0, 0, Time.deltaTime * 3);
        if (timer <= 1)
            {

                if (transform.rotation.z >= 20)
                {
                    transform.Rotate(0, 0, Time.deltaTime * -15);

                }

                if (transform.rotation.z <= -20)
                {
                    transform.Rotate(0, 0, Time.deltaTime * 9);
                }
            }

        if (transform.position.x > 3.5f || transform.position.y > 7f || transform.position.x < -3.5f)
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
