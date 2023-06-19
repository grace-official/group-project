using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItself : MonoBehaviour
{
    public GameObject gameObject;
    public KeyCode inputToDestroy;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.SetActive(true);
            if(Input.GetKeyDown(inputToDestroy))
            {
                Destroy(gameObject);
            }
        }
    }
}
