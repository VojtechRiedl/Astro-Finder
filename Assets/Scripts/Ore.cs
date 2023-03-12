using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    int a = 20;
    [SerializeField]
    private oretype type;
    enum oretype {
        iron, copper, ignium, sensium, uranium, iridium 
    }

    public void GetMined() {
        Debug.Log("mined");
        switch (type) {
            case oretype.iron:
                Player.instance.resources.AddIron(a);
                break;
            case oretype.copper:
                Player.instance.resources.AddCopper(a);
                break;
            case oretype.ignium:
                Player.instance.resources.AddIgnium(a);
                break;
            case oretype.sensium:
                Player.instance.resources.AddSensium(a);
                break;
            case oretype.uranium:
                Player.instance.resources.AddUranium(a);
                break;
            case oretype.iridium:
                Player.instance.resources.AddIridium(a);
                break;
        }
    }
}
