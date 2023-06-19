using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSecurityDoor : MonoBehaviour
{
    public IsBroken isBroken;

    public GameObject gameObject1;

    private void Start()
    {
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if(isBroken.objectIsBroken)
        {
            gameObject.SetActive(false);
        }
    }
}
