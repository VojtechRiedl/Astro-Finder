using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    [SerializeField]
    private AudioSource select;
    public void ClickStart() {
        select.Play();
        Invoke("PlayScene", 0.15f);
        
    }

    public void Exit() {
        select.Play();
        Invoke("EndGame", 0.15f);
        
    }

    void PlayScene()
    {
        SceneManager.LoadScene("Scenes/MainScene");
    }

    void EndGame()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
