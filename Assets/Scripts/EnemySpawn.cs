using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy1L,enemy2L,enemy3L,enemy4L;
    public GameObject enemy1R, enemy2R, enemy3R,enemy4R;
    
    float randomX,randomY,randomX2,randomX3,randomS, randomS2;
    Vector3 whereToSpawn,treeLeft,treeRight;
    public float spawnRate = 0.2f;
    public float spawnRate2 = 5f;
    float nextSpawn = 0.0f;
    public int randomR,randomR2;
    
    
    void Start()
    {
        randomR = 1;
    }

    // Update is called once per frame
    void Update()
    {
        spawn();
    }

    private void spawn()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + (UnityEngine.Random.Range(1,3) - 0.6f);
            randomX = UnityEngine.Random.Range(-2.6f, 2.6f);
            randomR = UnityEngine.Random.Range(1, 9);
            randomS = UnityEngine.Random.Range(0.1f,0.3f);
            randomS2 = UnityEngine.Random.Range(0.1f, 0.3f);
            randomX2 = UnityEngine.Random.Range(-2.4f, -1.4f);
            randomX3 = UnityEngine.Random.Range(1.35f, 2.4f);
            randomY = UnityEngine.Random.Range(-10f, -5.6f);
            randomR2 = UnityEngine.Random.Range(1, 3);

            treeLeft = new Vector3(randomX2, randomY, 2);
            treeRight = new Vector3(randomX3, randomY, 2);

            whereToSpawn = new Vector3(randomX, -6,2);
            if (randomR == 1) 
            { 
                Instantiate(enemy1L, whereToSpawn, Quaternion.identity);
                Instantiate(enemy2R, whereToSpawn, Quaternion.identity);

                enemy1L.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
                enemy1L.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS2, enemy1L.transform.localScale.y - randomS2);
            }
            if (randomR == 2)
            {
                Instantiate(enemy1R, whereToSpawn, Quaternion.identity);
                enemy1R.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
            }
            if (randomR == 3)
            {
                Instantiate(enemy2L, whereToSpawn, Quaternion.identity);
                enemy2L.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
            }
            if (randomR == 4)
            {
                Instantiate(enemy2R, whereToSpawn, Quaternion.identity);
                enemy2R.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
            }
            if (randomR == 5)
            {
                Instantiate(enemy3L, whereToSpawn, Quaternion.identity);
                enemy3L.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
            }
            if (randomR == 6)
            {
                Instantiate(enemy2R, whereToSpawn, Quaternion.identity);
                enemy2R.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
            }
            if (randomR == 7)
            {
                Instantiate(enemy4R, treeRight, Quaternion.identity);
                enemy4R.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
            }
            if (randomR == 8)
            {
                Instantiate(enemy4L, treeLeft, Quaternion.Euler(0, 180, 0));
                enemy4L.transform.localScale = new Vector2(enemy1L.transform.localScale.x - randomS, enemy1L.transform.localScale.y - randomS);
            }
        }
    }
}
