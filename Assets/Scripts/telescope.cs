using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telescope : MonoBehaviour, IInteractable
{

    [SerializeField]
    private GameObject planetSelection;
    private void Start()
    {
        planetSelection = GameObject.FindWithTag("planetSelection");
        planetSelection.SetActive(false);
    }
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
            planetSelection.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
    }
}
