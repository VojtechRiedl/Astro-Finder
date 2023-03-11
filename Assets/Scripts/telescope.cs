using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telescope : MonoBehaviour, IInteractable
{

    [SerializeField]
    private GameObject PlanetSelection;
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
        PlanetSelection.SetActive(true);
        Debug.Log("ahoj");
    }

}
