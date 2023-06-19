using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool hasItem;
    public string gameObjectTag;

    private void Start()
    {
        hasItem = false;
    }
}
