using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOff : MonoBehaviour
{
    public GameObject gameObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
