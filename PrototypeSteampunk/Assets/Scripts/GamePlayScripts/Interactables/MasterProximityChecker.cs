using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterProximityChecker : MonoBehaviour
{
    public GameObject firstWarning;

    public ProximityChecker firstProx;

    private void Start()
    {
        firstWarning.SetActive(false);
    }

    private void Update()
    {
        if (firstProx.isTouchingPlayer)
        {
            firstWarning.SetActive(true);
        }
    }
}
