using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PoolSpawn : MonoBehaviour
{
    public GameObject prefab, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8, prefab9, prefab10, prefab11;
    private GameObject obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11;

    private Pool pool, pool2, pool3, pool4, pool5, pool6, pool7, pool8, pool9, pool10, pool11;

    private float randomX,randomX2,randomX3, randomY, randomR,randomX4,randomY2;

    private float spawnTime = 1;
    private float tm;
    private int time,health;
    int hp=50;
    void Start()
    {
        pool = new Pool(prefab);
        pool2 = new Pool(prefab2);
        pool3 = new Pool(prefab3);
        pool4 = new Pool(prefab4);
        pool5 = new Pool(prefab5);
        pool6 = new Pool(prefab6);
        pool7 = new Pool(prefab7);
        pool8 = new Pool(prefab8);
        pool9 = new Pool(prefab9);
        pool10= new Pool(prefab10);
        pool11 = new Pool(prefab11);

        health = PlayerPrefs.GetInt("life");
    }

    // Update is called once per frame
    void Update()
    {
        tm += Time.deltaTime;
        time = Mathf.RoundToInt(tm);
        randomX = UnityEngine.Random.Range(-2.6f, 2.6f);
        randomX2 = UnityEngine.Random.Range(-2.4f, -1.4f);
        randomX3 = UnityEngine.Random.Range(1.35f, 2.4f);
        randomX4 = UnityEngine.Random.Range(4f, 6f);
        randomY = UnityEngine.Random.Range(-10f, -5.6f);
        randomY2 = UnityEngine.Random.Range(-3f, 0.5f);
        randomR = UnityEngine.Random.Range(1, 12);

        health = PlayerPrefs.GetInt("life");
        
        ObjectSpwn();
        ObjectControl();
    }

    public void ObjectSpwn()
    {
        if (randomR == 1 && time == spawnTime)
        {
            spawnTime = spawnTime + 1f;
            obj = pool.TakeObjPool();
            obj.transform.position = new Vector3(randomX, -6.2f, 2);
        }
        if (randomR == 2 && time == spawnTime)
        {
            spawnTime = spawnTime + 1;
            obj2 = pool2.TakeObjPool();
            obj2.transform.position = new Vector3(randomX, -6.2f, 2);
        }
        if (randomR == 3 && time == spawnTime)
        {
            spawnTime = spawnTime + 1;
            obj3 = pool3.TakeObjPool();
            obj3.transform.position = new Vector3(randomX, -6.2f, 2);

            obj11 = pool11.TakeObjPool();
            obj11.transform.position = new Vector3(-randomX4, randomY2, 2);
        }
        if (randomR == 4 && time == spawnTime && time > 50)
        {
            spawnTime = spawnTime + 1;
            obj4 = pool4.TakeObjPool();
            obj4.transform.position = new Vector3(randomX2, randomY, 2);
        }
        if (randomR == 5 && time == spawnTime)
        {
            spawnTime = spawnTime + 1;
            obj5 = pool5.TakeObjPool();
            obj5.transform.position = new Vector3(randomX, -6.2f, 2);

            obj10 = pool10.TakeObjPool();
            obj10.transform.position = new Vector3(randomX4, randomY2, 2);
        }
        if (randomR == 6 && time == spawnTime)
        {
            spawnTime = spawnTime + 1;
            obj6 = pool6.TakeObjPool();
            obj6.transform.position = new Vector3(randomX, -6.2f, 2);
        }
        if (randomR == 7 && time == spawnTime)
        {
            spawnTime = spawnTime + 1;
            obj7 = pool.TakeObjPool();
            obj7.transform.position = new Vector3(randomX, -6.2f, 2);
        }
        if (randomR == 8 && time == spawnTime && time > 50)
        {
            spawnTime = spawnTime + 1;
            obj8 = pool8.TakeObjPool();
            obj8.transform.position = new Vector3(randomX3, randomY, 2);
        }

        if (time == hp)
        {
            hp = hp + 50;
            obj9 = pool9.TakeObjPool();
            obj9.transform.position = new Vector3(randomX, -6.2f, 2);
        }

        if (randomR == 10 && time == spawnTime && time > 100)
        {
            spawnTime = spawnTime + 1;
            obj10 = pool10.TakeObjPool();
            obj10.transform.position = new Vector3(randomX4, randomY2, 2);
        }

        if (randomR == 11 && time == spawnTime && time > 100)
        {
            spawnTime = spawnTime + 1;
            obj11 = pool11.TakeObjPool();
            obj11.transform.position = new Vector3(-randomX4, randomY2, 2);
        }
    }

    public void ObjectControl()
    {
        if (obj.transform.position.x > 3.5f || obj.transform.position.y > 7f || obj.transform.position.x < -3.5f || obj.activeSelf==false)
        {
            pool.AddObjPool(obj);
        }
        if (obj2.transform.position.x > 3.5f || obj2.transform.position.y > 7f || obj2.transform.position.x < -3.5f || obj2.activeSelf == false)
        {
            pool2.AddObjPool(obj2);
        }
        if (obj3.transform.position.x > 3.5f || obj3.transform.position.y > 7f || obj3.transform.position.x < -3.5f || obj3.activeSelf == false)
        {
            pool3.AddObjPool(obj3);
        }
        if (obj4.transform.position.y > 6f || obj4.activeSelf == false)
        {
            pool4.AddObjPool(obj4);
        }
        if (obj5.transform.position.x > 3.5f || obj5.transform.position.y > 7f || obj5.transform.position.x < -3.5f || obj5.activeSelf == false)
        {
            pool5.AddObjPool(obj5);
        }
        if (obj6.transform.position.x > 3.5f || obj6.transform.position.y > 7f || obj6.transform.position.x < -3.5f || obj6.activeSelf == false)
        {
            pool6.AddObjPool(obj6);
        }
        if (obj7.transform.position.x > 3.5f || obj7.transform.position.y > 7f || obj7.transform.position.x < -3.5f || obj7.activeSelf == false)
        {
            pool7.AddObjPool(obj7);
        }
        if (obj8.transform.position.y > 6f || obj8.activeSelf == false)
        {
            pool8.AddObjPool(obj8);
        }
        if (obj9.transform.position.x > 3.5f || obj9.transform.position.y > 7f || obj9.transform.position.x < -3.5f || obj9.activeSelf == false)
        {
            pool9.AddObjPool(obj9);
        }
        if (transform.position.x > 7f || transform.position.y > 7f || transform.position.x < -7f)
        {
            pool10.AddObjPool(obj10);
        }
        if (transform.position.x > 6.5f || transform.position.y > 7f || transform.position.x < -6.5f)
        {
            pool11.AddObjPool(obj11);
        }
    }
}
