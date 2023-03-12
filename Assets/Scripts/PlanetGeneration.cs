using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlanetGeneration : MonoBehaviour
{
    [SerializeField]
    private Player player;

    [SerializeField]
    private PlanetManager planetManager;
    private bool isGenerated = false;

    [SerializeField]
    PlanetyButtons planetyButtons;


    public bool IsGenerated { get => isGenerated; set => isGenerated = value; }

    void Start()
    {
        player.ActualPlanet = SpawnPlanet(); 
    }

    void Update()
    {
        if (!isGenerated)
        {
            player.ActualPlanet = SpawnPlanet();
        }
    }
    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            gameObject.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0;
        }
    }

    private Planet SpawnPlanet()
    {
        var planet = planetManager.spawnRandomPlanet();
        isGenerated = true;
        planet = planet.GeneratePlanet();
        player.gameObject.transform.position = new Vector3(planet.SpawnPoint.gameObject.transform.position.x, planet.SpawnPoint.gameObject.transform.position.y, player.gameObject.transform.position.z);

        if (planetyButtons != null) // button planety v telescopu
        {
            planetyButtons.MakeButtonPlanet(planet);
        }
        return planet;
        
    }
    
}
