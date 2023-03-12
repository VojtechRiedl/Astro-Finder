using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class showInfo : MonoBehaviour
{
    [Header("Planet Type")]
    [SerializeField]  //[SerializeField]
    private TextMeshProUGUI planetName;
    [SerializeField]
    private TextMeshProUGUI planetDesc;
    [SerializeField]
    private TextMeshProUGUI statsText;
    [SerializeField]
    private string requires;
    [SerializeField]
    private string contains;
    [SerializeField]
    private string threatlevel;
    [SerializeField]
    private string cycle;
    [SerializeField]
    private Image image;
    [SerializeField]
    private Planet realPlanet;
    [SerializeField]
    private bool markedToTeleport = false;

    private void Start()
    {
        planetName = GameObject.FindWithTag("planetName").GetComponent<TextMeshProUGUI>();
        planetDesc = GameObject.FindWithTag("planetDesc").GetComponent<TextMeshProUGUI>();
        statsText = GameObject.FindWithTag("statsText").GetComponent<TextMeshProUGUI>();
    }

    public void OnClickShow()
    {

        Debug.Log("ao");
        planetName.text = "Toxic";
        planetDesc.text = "Toxicka planeta. Poprvé nalezena roku 4025";
        statsText.text = "Requires: " + requires + "\nContains: " + contains + "\nThreat level: " + threatlevel + "\nCycle: " + cycle;
    }

    public Planet GetRealPlanet()
    {
        return realPlanet;
    }
    public void SetRealPlanet(Planet pl)
    {
        realPlanet = pl;
    }
    public bool GetMarkedToTeleport()
    {
        return markedToTeleport;
    }
    public void SetMarkedToTeleport(bool value)
    {
        markedToTeleport = value;
    }
}
