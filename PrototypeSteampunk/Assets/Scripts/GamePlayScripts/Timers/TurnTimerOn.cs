using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTimerOn : MonoBehaviour
{
    public GameObject timer;
    public GameObject uiTimer;
    public CountdownTimer createTimer;

    public float startingTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer.GetComponent<CountdownTimer>().enabled = true;
            uiTimer.SetActive(true);
            createTimer.startingTime = startingTime;
            createTimer.currentTime = startingTime;
        }
    }
}
