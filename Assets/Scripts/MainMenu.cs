using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void Start() {
        SceneManager.LoadScene("MainScene");
    }

    public void Exit() {
        Application.Quit();
    }
}
