using System;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGeneration : MonoBehaviour
{
    [SerializeField]
    List<GameObject> planets = new List<GameObject>();
    [SerializeField]
    private Player player;

    private bool isGenerated = false;
    void Start()
    {
        SpawnPlanet();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!isGenerated)
            {
                SpawnPlanet();
            }
        }

    }


    private Planet GetRandomPlanet()
    {
        return planets[UnityEngine.Random.Range(0, planets.Count)]
                .GetComponent<Planet>();
    }

    private Planet SpawnPlanet()
    {
        var planet = GetRandomPlanet();
        isGenerated = true;
        planet.GeneratePlanet();
        player.gameObject.transform.position = planet.SpawnPoint.transform.position;
        return planet;
        
    }
}
