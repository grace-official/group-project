using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Collectable : MonoBehaviour
{
    public Level1Inventory inv;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !inv.hasItem)
        {
            Destroy(gameObject);
        }
    }
}
