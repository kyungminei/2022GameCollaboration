﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("Ingame");
    }

    public void HowToScene()
    {
        SceneManager.LoadScene("Howtoplay");
    }
}
