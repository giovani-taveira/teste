﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public float timeLeft = 0.0f;
    public TextMeshProUGUI timer; // used for showing countdown from 3, 2, 1 

    void Update()
    {
        timeLeft += Time.deltaTime; //timer.text = (timeLeft).ToString("0");
        timer.SetText(((float)timeLeft * 10).ToString("n0") + "%");
        if (timeLeft > 10)
        {
            SceneManager.LoadScene(1);
            //Do something useful or Load a new game scene depending on your use-case
        }
    }

}
