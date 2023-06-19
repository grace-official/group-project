using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public ItemDestination itemDestination;
    public bool nextLevel;

    private void Update()
    {
        if(itemDestination.partCompleted1 && itemDestination.partCompleted2 && itemDestination.partCompleted3)
        {
            itemDestination.partCompleted1 = false;
            itemDestination.partCompleted2 = false;
            itemDestination.partCompleted3 = false;
            nextLevel = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
