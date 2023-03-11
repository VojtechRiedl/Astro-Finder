using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private InputManager InputManager;
    [SerializeField]
    private GameObject upgrades;


    // Start is called before the first frame update

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
        if(Input.GetKeyDown(KeyCode.U))
        {
            upgrades.SetActive(!upgrades.active);

        }
        
    }
}
