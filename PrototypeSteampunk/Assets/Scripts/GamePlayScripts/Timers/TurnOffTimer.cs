using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTimer : MonoBehaviour
{
    public GameObject timer;
    public GameObject uiTimer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            timer.GetComponent<CountdownTimer>().enabled = false;
            uiTimer.SetActive(false);
        }
    }
}
