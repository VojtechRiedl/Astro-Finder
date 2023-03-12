using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class buttons : MonoBehaviour
{
    [SerializeField]
    private PlanetManager plman;
    [SerializeField]
    private TextMeshProUGUI planetNameText;

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
        float buttonX = Random.Range(-600,600);
        float buttonY = Random.Range(-200,200);
        Debug.Log(buttonX + " " + buttonY);
        Vector3 buttonPos = new Vector3(buttonX + 742, buttonY + 761, 0);

        Button planetButton = Instantiate(emptyButton, buttonPos, Quaternion.identity, buttonsParent.transform);
        planetButton.onClick.AddListener(delegate () { ButtonClicked(); });
        planetButton.GetComponent<showInfo>().SetRealPlanet(planet);

        switch (planet.Type)
        {
            case Planet.planettype.green:
                planetButton.GetComponent<Image>().sprite = greenPlanet;
                break;
            case Planet.planettype.toxic:
                planetButton.GetComponent<Image>().sprite = toxicPlanet;
                break;
            case Planet.planettype.magma:
                planetButton.GetComponent<Image>().sprite = magmaPlanet;
                break;
            case Planet.planettype.winter:
                planetButton.GetComponent<Image>().sprite = winterPlanet;
                break;
            case Planet.planettype.iradiated:
                planetButton.GetComponent<Image>().sprite = iradiatedPlanet;
                break;
            case Planet.planettype.storm:
                planetButton.GetComponent<Image>().sprite = stormPlanet;
                break;
            case Planet.planettype.earthquake:
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
        /*foreach (Transform child in buttonsParent.transform)
        {
            showInfo shin = child.GetComponent<showInfo>();

            if (shin != null && shin == true)
            {
                Debug.Log("teleporting to " + shin.GetRealPlanet());
                // teleportation HERE







            }
        }*/


        
    }
}
