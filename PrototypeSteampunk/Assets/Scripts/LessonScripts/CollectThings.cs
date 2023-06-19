using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectThings : MonoBehaviour
{
    public AudioSource collectSound;
    private void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        Scoring.theScore += 50;
    }
}
