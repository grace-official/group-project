using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedReduction : MonoBehaviour
{
    public AdvancedPlayerController controller;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SustainedDamagingObject")
        {
            controller.speed -= controller.speed / 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "SustainedDamagingObject")
        {
            controller.speed = controller.startingSpeed;
        }
    }
}
