using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spwn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;

    private Pool pool;
    private Pool pool2;

    private float randomX,randomY,randomZ;
    void Start()
    {
        pool = new Pool(prefab);
        pool2 = new Pool(prefab2);

        StartCoroutine(CreateObject());
    }

    private void Update()
    {
        randomX = UnityEngine.Random.Range(-2.6f, 2.6f);
        randomY= UnityEngine.Random.Range(-2.6f, 2.6f);
        randomZ = UnityEngine.Random.Range(-25f, 25f);
    }

    IEnumerator CreateObject()
    {
        while (true)
        {
            GameObject obj = pool.TakeObjPool();
            obj.transform.position = new Vector3(randomX, -6, 2);
            obj.transform.rotation = Quaternion.Euler(0f, 0f, randomZ);

            GameObject obj2= pool2.TakeObjPool();
            obj2.transform.position = new Vector3(randomY, -6, 2);
            obj2.transform.rotation = Quaternion.Euler(0f, 0f, randomZ);
            
            yield return new WaitForSeconds(3f);

            pool.AddObjPool(obj);
            pool2.AddObjPool(obj2);
        }
    }
   
}
