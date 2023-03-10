using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private InputManager InputManager;
    [SerializeField]
    private float speed = 5f;
    void Update()
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

        vector = vector.normalized;

        transform.position += new Vector3(vector.x,0f,vector.y) * speed * Time.deltaTime; 
    }
}
