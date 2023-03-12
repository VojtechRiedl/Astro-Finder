using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour {
    [SerializeField] private GameObject winComp;
    [SerializeField] private GameObject loseComp;
    [SerializeField] private TextMeshProUGUI finalMassage;
    public static bool win;
    public static DeathManager dm;

    private void Awake() {
        dm = this;
    }

    void Start() {
        if (win) {
            winComp.SetActive(true);
            finalMassage.text = "You win!";
        }
        else {
            loseComp.SetActive(true);
            finalMassage.text = "You lose";
        }
    }

    public void MainMenu() {
        SceneManager.LoadScene("Scenes/MainMenu");
    }
    public void Exit() {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
