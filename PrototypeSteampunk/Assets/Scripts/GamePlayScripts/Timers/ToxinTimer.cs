using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToxinTimer : MonoBehaviour
{
    // Timers
    public float startingTime;
    public float currentTime;

    public float gameObjectStartingTime;
    public float gameObjectCurrentTime;

    // this is set to public for testing reasons
    public bool objectOn;

    public GameObject gameObject;

    public Text countDownText;
    void Start()
    {
        currentTime = startingTime;
        gameObjectCurrentTime = gameObjectStartingTime;
        gameObject.SetActive(false);

        objectOn = false;
    }

    void Update()
    {
        if(objectOn)
        {
            gameObjectCurrentTime -= Time.deltaTime;
            if(gameObjectCurrentTime <= 0)
            {
                gameObject.SetActive(false);
                currentTime = startingTime;
                objectOn = false;
            }
        }
        else
        {
            currentTime -= 1 * Time.deltaTime;
            countDownText.text = currentTime.ToString("0");
            if(currentTime <= 0)
            {
                gameObject.SetActive(true);
                gameObjectCurrentTime = gameObjectStartingTime;
                objectOn = true;
            }
        }
    }
}
