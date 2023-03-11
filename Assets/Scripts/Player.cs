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
    private float jumpForce = 1f;

    private GameObject Upgrades;


    // Start is called before the first frame update


    [SerializeField]
    private Rigidbody playerRigid;

    private Planet actualPlanet;

    private CharacterController controller;
    private bool isJumping = false;
    public Planet ActualPlanet { get => actualPlanet; set => actualPlanet = value; }
    public Rigidbody PlayerRigid { get => playerRigid; }

    private Vector3 moveDirection;

    void Start()
    {
    }
    void Update()
    {

        movement();
    }

    public void movement()
    {
        Vector2 vector = InputManager.GetVector2();
        if (Input.GetKey(KeyCode.W))
        {
            vector.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vector.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            vector.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vector.x += 1;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            playerRigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        vector = vector.normalized;

        transform.position += new Vector3(vector.x,0f, vector.y) * speed * Time.deltaTime;
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        Debug.DrawRay(moveDirection,Vector3.forward * 5, Color.red);

    }

    private void FixedUpdate()
    {
        playerRigid.MovePosition(playerRigid.position + transform.TransformDirection(moveDirection) * speed * Time.deltaTime);

        if(Input.GetKeyDown("u"))
        {
            Upgrades.SetActive(!Upgrades.active);

        }
        

    }
}
