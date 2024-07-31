using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] uint initPoolSize;
    [SerializeField]  PooledObject objectToPool;

    private Stack<PooledObject> stack;  
    // Start is called before the first frame update
    void Start()
    {
        SetupPool();
    }

    private void SetupPool()
    {
        stack = new Stack<PooledObject>();
        PooledObject instance = null;

        for (int i = 0; i < initPoolSize; i++)
        {
            instance = Instantiate(objectToPool);
            instance.Pool= this;
            instance.gameObject.SetActive(false);
            stack.Push(instance);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
