using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Inventory : MonoBehaviour
{
    public bool hasItem;

    public string gameObjectTag1;
    public string gameObjectTag2;
    public string gameObjectTag3;

    public bool coll1Collected;
    public bool coll2Collected;
    public bool coll3Collected;

    private void Start()
    {
        hasItem = false;
    }

    private void Update()
    {
        if(!hasItem)
        {
            coll1Collected = false;
            coll2Collected = false;
            coll3Collected = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObjectTag1 && !hasItem)
        {
            coll1Collected = true;
            hasItem = true;
        }

        if (other.gameObject.tag == gameObjectTag2 && !hasItem)
        {
            coll2Collected = true;
            hasItem = true;
        }

        if (other.gameObject.tag == gameObjectTag3 && !hasItem)
        {
            coll3Collected = true;
            hasItem = true;
        }
    }
}
