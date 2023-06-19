using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityChecker : MonoBehaviour
{
    public bool isTouchingPlayer;
    public GameObject gO;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isTouchingPlayer = true;
            gO.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isTouchingPlayer = false;
        gO.SetActive(false);
    }
}
