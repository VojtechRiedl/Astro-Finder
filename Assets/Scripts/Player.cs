using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private InputManager InputManager;

    [SerializeField]
    private GameObject Upgrades;


    [SerializeField]
    private Rigidbody playerRigid;

    private Planet actualPlanet;

    public Planet ActualPlanet { get => actualPlanet; set => actualPlanet = value; }
    public Rigidbody PlayerRigid { get => playerRigid; }

    private Vector3 moveDirection;

    void Start()
    {
    }
    void Update()
    {
    }

   

    private void FixedUpdate()
    {
        if(Input.GetKeyDown("u"))
        {
            Upgrades.SetActive(!Upgrades.active);

        }
        
    }
}
