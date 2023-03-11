using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInteraction : MonoBehaviour
{
    [SerializeField]
    public Transform cam;
    [SerializeField]
    public float interactionRange;
    [SerializeField]
    public bool inRange = false;

    [SerializeField]
    public GameObject interactionText;

    void Update()
    {
        RaycastHit hit;
        inRange = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, interactionRange);


        if (Input.GetKeyDown(KeyCode.E ) && inRange)
        {
            if( hit.transform.GetComponent<IInteractable>() != null )
            {
                hit.transform.GetComponent<IInteractable>().Interact(transform);
            }
        }

        UiUpdate(hit);
    }

     void UiUpdate(RaycastHit hit)
    {
        if (inRange && hit.transform.GetComponent<IInteractable>() != null)
        {
            interactionText.SetActive(true);
            
        }
        else
        {
            interactionText.SetActive(false);
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(cam.position, interactionRange);
    }
}
