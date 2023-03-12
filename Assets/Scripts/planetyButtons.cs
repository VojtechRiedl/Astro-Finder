using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlanetyButtons : MonoBehaviour
{
    [SerializeField]
    private PlanetManager plman;
    [SerializeField]
    private Text planetNameText;

    [SerializeField] private Sprite greenPlanet;
    [SerializeField] private Sprite toxicPlanet;
    [SerializeField] private Sprite magmaPlanet;
    [SerializeField] private Sprite winterPlanet;
    [SerializeField] private Sprite iradiatedPlanet;
    [SerializeField] private Sprite stormPlanet;
    [SerializeField] private Sprite earthquakePlanet;
    [SerializeField] private Sprite defaultPlanet;
    [SerializeField] private Button emptyButton;
    [SerializeField] private GameObject buttonsParent;
    private Planet planetToTeleport;

    public void MakeButtonPlanet(Planet planet)
    {

        Debug.Log("ButtonMade");
        float buttonX = Random.Range(-650, 650);
        float buttonY = Random.Range(220, 400);
        Vector3 buttonPos = new Vector3(buttonX, buttonY, 0);

        Button planetButton = Instantiate(emptyButton, buttonPos, Quaternion.identity, buttonsParent.transform);
        planetButton.onClick.AddListener(delegate () { ButtonClicked(); });
        planetButton.GetComponent<showInfo>().SetRealPlanet(planet);

        switch (planet.GetPlanetType())
        {
            case "green":
                planetButton.GetComponent<Image>().sprite = greenPlanet;
                break;
            case "toxic":
                planetButton.GetComponent<Image>().sprite = toxicPlanet;
                break;
            case "magma":
                planetButton.GetComponent<Image>().sprite = magmaPlanet;
                break;
            case "winter":
                planetButton.GetComponent<Image>().sprite = winterPlanet;
                break;
            case "iradiated":
                planetButton.GetComponent<Image>().sprite = iradiatedPlanet;
                break;
            case "storm":
                planetButton.GetComponent<Image>().sprite = stormPlanet;
                break;
            case "earthquake":
                planetButton.GetComponent<Image>().sprite = earthquakePlanet;
                break;
            default:
                planetButton.GetComponent<Image>().sprite = defaultPlanet;
                break;
        }

        void ButtonClicked()
        {
            Planet pl = planetButton.GetComponent<showInfo>().GetRealPlanet();
            Debug.Log("oznac na teleportaci" + planetButton.GetComponent<showInfo>().GetRealPlanet());

            foreach (Transform child in buttonsParent.transform)
            {
                showInfo shin = child.GetComponent<showInfo>();

                if (shin != null)
                {
                    shin.SetMarkedToTeleport(false);
                }
            }

            planetButton.GetComponent<showInfo>().SetMarkedToTeleport(true);

        }
        

    }
    public void GoButton()
    {
        foreach (Transform child in buttonsParent.transform)
        {
            showInfo shin = child.GetComponent<showInfo>();

            if (shin != null && shin == true)
            {
                Debug.Log("teleporting to " + shin.GetRealPlanet());
                // teleportation HERE







            }
        }
    }
}
