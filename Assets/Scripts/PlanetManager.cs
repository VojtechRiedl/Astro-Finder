using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{

    List<Planet> generatedPlanets = new List<Planet>();

    [SerializeField]
    List<GameObject> planets = new List<GameObject>();

    void Awake()
    {
        GeneratePlanet();
    }

    void Start()
    {
        
    }

    void Update()
    {
        foreach (var planet in generatedPlanets)
        {
            Debug.Log(planet.ReadyToDestroy);
            if (planet.ReadyToDestroy)
            {
                GeneratePlanet();
                planet.DestroyPlanet();
                generatedPlanets.Remove(planet);
            }
        }
    }

    public void GeneratePlanet()
    {
        for (int i = 0; i < 3; i++)
        {
            generatedPlanets.Add(GetRandomPlanet());
        }
        
    }
    public Planet GetRandomPlanet()
    {
        return planets[UnityEngine.Random.Range(0, planets.Count)]
                .GetComponent<Planet>();
    }
    public Planet spawnRandomPlanet()
    {
        return generatedPlanets[UnityEngine.Random.Range(0, generatedPlanets.Count)];
    }
    
}
