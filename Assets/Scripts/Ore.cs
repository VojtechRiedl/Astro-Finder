using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    int amount = 20;
    [SerializeField]
    private oretype type;
    enum oretype {
        iron, copper, ignium, sensium, uranium, iridium 
    }

    public void GetMined() {
        switch (type) {
            case oretype.iron:
                Player.instance.resources.AddIron(amount);
                break;
            case oretype.copper:
                Player.instance.resources.AddCopper(amount);
                break;
            case oretype.ignium:
                Player.instance.resources.AddIgnium(amount);
                break;
            case oretype.sensium:
                Player.instance.resources.AddSensium(amount);
                break;
            case oretype.uranium:
                Player.instance.resources.AddUranium(amount);
                break;
            case oretype.iridium:
                Player.instance.resources.AddIridium(amount);
                break;
        }
    }
}
