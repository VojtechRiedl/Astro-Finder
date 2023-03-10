using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerAction inputActions;
    private void Awake()
    {
        inputActions = new PlayerAction();
        inputActions.Player.Enable();
        
    }

    void Update()
    {
        
    }

    public Vector2 GetVector2()
    {
        Vector2 vector = inputActions.Player.move.ReadValue<Vector2>();

        return vector;
    }
}
