using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    float sensitivity = 1f;
    Camera kamera;
    Vector2 vector;
    [SerializeField] Player player;
    void Start()
    {
        kamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()   
    {
        /*if (GameManager.manager.currentGameState != GameManager.gameState.go)
        {
            return;
        }*/
        /*vector.x += Input.GetAxis("Mouse X") * sensitivity;
        vector.y -= Input.GetAxis("Mouse Y") * sensitivity;
        vector.y = Mathf.Clamp(vector.y, -90, 90);
        kamera.transform.rotation = Quaternion.Euler(vector.y, vector.x, 0);
        player.transform.rotation = Quaternion.Euler(0, vector.x, 0);*/

    }
}