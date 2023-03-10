using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIneractionBox : MonoBehaviour, IInteractable
{
    public void DoTralala()
    {
        Debug.Log("tralalalalalala");
    }

    public void Interact(Transform interactorTransform)
    {
        DoTralala();
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
