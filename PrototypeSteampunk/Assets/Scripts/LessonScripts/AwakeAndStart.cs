using UnityEngine;
using System.Collections;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
    {
        //Will run even when the object is disabled
        Debug.Log("Awake called.");
    }


    void Start()
    {
        //Will run when the object is enabled
        Debug.Log("Start called.");
    }
}
