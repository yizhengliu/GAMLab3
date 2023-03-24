using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    float timeLeft = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("game lost");
        }
        // format to a string with no decimal places
        timeText.text = timeLeft.ToString("0");

    }

    public void TargetDestroyed()
    {
        if (GameObject.FindObjectsOfType<Destroyable>().Length == 0)
        {
            Debug.Log("game won");
        }
    }
}
