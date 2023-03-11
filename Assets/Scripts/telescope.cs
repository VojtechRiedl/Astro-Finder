using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telescope : MonoBehaviour, IInteractable
{

    [SerializeField]
    private GameObject PlanetSelection;
    [SerializeField]
    private int numOfPlanets = 3;
    [SerializeField]
    private int lastNumOfPlanets;
    [SerializeField]
    private bool isActive = false;
    [SerializeField]
    private ItemInteraction itemInteraction;
    public string GetInteractText()
    {
        return "box";
    }

    public Transform GetTransform()
    {
        return transform;
    }

    public void Interact(Transform interactorTransform)
    {
        if (!isActive)
        {
            PlanetSelection.SetActive(true);
            isActive = true;
        }
        else
        {
            PlanetSelection.SetActive(false);
            isActive = false;
        }
        
        numOfPlanets = lastNumOfPlanets;
    }

    public void Update()
    {
        if(!itemInteraction.inRange)
        {
            PlanetSelection.SetActive(false);
        }
    }

}
