using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openButtonUpgrades : MonoBehaviour
{

    [SerializeField]
    private GameObject MainButtton;

    [SerializeField]
    private GameObject otherMainButton1;
    [SerializeField]
    private GameObject otherMainButton2;
    [SerializeField]
    private GameObject otherMainButton3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnClickUpLil()
    {
        MainButtton.SetActive(true);


        otherMainButton1.SetActive(false);
        otherMainButton2.SetActive(false);
        otherMainButton3.SetActive(false);


    }
}
