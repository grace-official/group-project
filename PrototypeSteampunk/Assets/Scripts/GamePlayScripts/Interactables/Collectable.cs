using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Inventory inv;

    private void Update()
    {
        if(inv.hasItem)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && inv.gameObjectTag == gameObject.tag && !inv.hasItem)
        {
            inv.hasItem = true;
        }
    }
}
