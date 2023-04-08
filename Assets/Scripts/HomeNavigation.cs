﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeNavigation : MonoBehaviour
{
    public GameObject tutorialImage; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tutorial()
    {

        SceneManager.LoadScene("Tutorial");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
