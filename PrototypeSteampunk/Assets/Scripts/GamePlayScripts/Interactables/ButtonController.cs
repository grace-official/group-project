using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject objectToToggle;
    public bool toggleAnObject;

    private void Update()
    {
        if (toggleAnObject)
        {
            objectToToggle.SetActive(true);
        }
        else
        {
            objectToToggle.SetActive(false);
        }
    }
}
