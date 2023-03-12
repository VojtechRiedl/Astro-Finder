using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player instance { get; private set; }
    [SerializeField]
    private GameObject planetSelection;
    [SerializeField]
    private InputManager InputManager;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private GameObject upgrades;

    [SerializeField]
    private GameObject firstPlanet;


    public Resources resources { get; private set; }
    public Stats stats { get; }
    bool active = false;

    // Start is called before the first frame update
    
    [SerializeField]
    private Rigidbody playerRigid;

    private Planet actualPlanet;

    public Planet ActualPlanet { get => actualPlanet; set => actualPlanet = value; }
    public Rigidbody PlayerRigid { get => playerRigid; }

    private void Awake() {
        instance = this;
    }

    void Start() {
        resources = GetComponent<Resources>();
        //actualPlanet = firstPlanet.GetComponent<Planet>();
        planetSelection.SetActive(false);
    }
    void Update()
    {
        try {
            if(actualPlanet.TimeToDestruction < 20 && !animator.enabled)
            {
                animator.enabled = true;
            }
            else if (actualPlanet.TimeToDestruction > 20 && animator.enabled)
            {
                animator.enabled = false;
            }
        }
        catch (Exception e) {
            //ignore
        }
    }

    

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (active == true)
            {
                upgrades.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                active = false;
            }
            else {
                upgrades.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
                active = true;
            }

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            planetSelection.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        
    }
}
