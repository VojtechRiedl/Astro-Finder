using System;
using System.Collections.Generic;
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

    private Planet SpawnPlanet()
    {
        var planet = planetManager.spawnRandomPlanet();
        isGenerated = true;
        planet = planet.GeneratePlanet();
        player.gameObject.transform.position = new Vector3(planet.SpawnPoint.gameObject.transform.position.x, planet.SpawnPoint.gameObject.transform.position.y, player.gameObject.transform.position.z);
        if (planetyButtons != null)
        {
            planetyButtons.MakeButtonPlanet(planet);
        }
        return planet;
        
    }
    
}
