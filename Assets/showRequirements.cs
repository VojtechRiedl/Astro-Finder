using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showRequirements : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI requires;
    [SerializeField]
    private TextMeshProUGUI does;
    [SerializeField]
    private GameObject idk;
    [SerializeField]
    private GameObject otherIdk1;
    [SerializeField]
    private GameObject otherIdk2;
    [SerializeField]
    private GameObject otherIdk3;
    [SerializeField]
    private GameObject otherIdk4;
    [SerializeField]
    private GameObject otherIdk5;
    [SerializeField]
    private string dela;
    [SerializeField]
    private string potrebuje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickShowReq()
    {
        idk.SetActive(true);
        does.text = "dela blablabla " + dela;
        requires.text = "potrebuje blablabla " + potrebuje;
        otherIdk1.SetActive(false);
        otherIdk2.SetActive(false);
        otherIdk3.SetActive(false);
        otherIdk4.SetActive(false);
        otherIdk5.SetActive(false);
    }
}
