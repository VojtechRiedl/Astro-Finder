using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void ClickStart() {
        SceneManager.LoadScene("Scenes/MainScene");
    }

    public void Exit() {
        Debug.Log("exit");
        Application.Quit();
    }
}
