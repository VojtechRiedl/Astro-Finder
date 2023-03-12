using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemInteraction : MonoBehaviour
{
    public Transform cam;
    public float interactionRange;
    public bool inRange = false;

    public GameObject interactionUI;
    public Text interactionText;


    void Update()
    {
        RaycastHit hit;
        inRange = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, interactionRange);

        if(inRange)
        {
           // interact.SetActive(true);
        }
        else
        {
           // interact.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E ) && inRange)
        {
            if( hit.transform.GetComponent<IInteractable>() != null )
            {
                hit.transform.GetComponent<IInteractable>().Interact(transform);
            }
        }

        //UiUpdate(hit);
    }

     void UiUpdate(RaycastHit hit)
    {
        if (inRange && hit.transform.GetComponent<IInteractable>() != null)
        {
            interactionText.text = hit.transform.GetComponent<IInteractable>().GetInteractText();
            interactionUI.SetActive(true);
        }
        else
        {
            interactionUI.SetActive(false);
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(cam.position, interactionRange);
    }
}
