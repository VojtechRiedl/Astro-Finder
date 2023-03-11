using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIneractionBox : MonoBehaviour, IInteractable
{
    

    public void Interact(Transform interactorTransform)
    {
        
    }
    public string GetInteractText()
    {
        return "box";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
