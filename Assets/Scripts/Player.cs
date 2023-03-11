using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private InputManager InputManager;
    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private Rigidbody playerRigid;

    private Planet actualPlanet;

    

    public Planet ActualPlanet { get => actualPlanet; set => actualPlanet = value; }
    public Rigidbody PlayerRigid { get => playerRigid; }


    void Start()
    {
        playerRigid.freezeRotation = true;
    }

    

}
