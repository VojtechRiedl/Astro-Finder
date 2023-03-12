using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
        [SerializeField]
    private GameObject planetSelection;
    [SerializeField]
    private InputManager InputManager;
    [SerializeField]
    private GameObject upgrades;

    bool active = false;

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
