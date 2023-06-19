using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestination : MonoBehaviour
{
    public Level1Inventory inv;

    public bool partCompleted1;
    public bool partCompleted2;
    public bool partCompleted3;

    public GameObject partPlacement1;
    public GameObject partPlacement2;
    public GameObject partPlacement3;

    public GameObject finalDoor;

    private void Update()
    {
        if(partCompleted1 && partCompleted2 && partCompleted3)
        {
            finalDoor.SetActive(true);
        }
    }

    private void Start()
    {
        finalDoor.SetActive(false);
        partPlacement1.SetActive(false);
        partPlacement2.SetActive(false);
        partPlacement3.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(inv.coll1Collected)
            {
                partCompleted1 = true;
                inv.hasItem = false;
                partPlacement1.SetActive(true);
            }

            if (inv.coll2Collected)
            {
                partCompleted2 = true;
                inv.hasItem = false;
                partPlacement2.SetActive(true);
            }

            if (inv.coll3Collected)
            {
                partCompleted3 = true;
                inv.hasItem = false;
                partPlacement3.SetActive(true);
            }
        }
    }
}
