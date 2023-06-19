using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBroken : MonoBehaviour
{
    public bool objectIsBroken;
    public MasterProximityChecker proxCheck;

    private void Start()
    {
        objectIsBroken = false;
    }

    private void Update()
    {
        if (objectIsBroken)
        {
            proxCheck.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            objectIsBroken = true;
        }
    }
}
