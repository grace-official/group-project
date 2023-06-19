using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public string gameObjectTag;
    public Inventory inv;
    public GameObject gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && inv.gameObjectTag == gameObjectTag && inv.hasItem)
        {
            inv.hasItem = false;
            if (gameObject.active == true)
            {
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.SetActive(true);
            }
        }
    }
}
