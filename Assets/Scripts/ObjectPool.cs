using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Pool
    {
        private GameObject prefab;
        private Stack<GameObject> objectPool = new Stack<GameObject>();

        public Pool (GameObject prefab)
        {
            this.prefab = prefab;
        }
        public void FullPool(int val)
        {
            for (int i=0; i< val; i++)
            {
                GameObject obj = Object.Instantiate(prefab);
                AddObjPool(obj);
            }
        }
        public GameObject TakeObjPool()
        {
            if (objectPool.Count > 0)
            {
                GameObject obj = objectPool.Pop();
                obj.gameObject.SetActive(true);

                return obj;
            }
            return Object.Instantiate(prefab);
        }
        public void AddObjPool(GameObject obj)
        {
            obj.gameObject.SetActive(false);
            objectPool.Push(obj);
        }
    }

