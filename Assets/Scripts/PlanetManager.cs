using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{

    List<Planet> generatedPlanets = new List<Planet>();

    [SerializeField]
    PlanetGeneration planetGeneration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var planet in generatedPlanets)
        {
            if (planet.ReadyToDestroy)
            {
                GeneratePlanet();
                planet.DestroyPlanet();
            }
        }
    }

    public void GeneratePlanet()
    {
        for (int i = 0; i < 3; i++)
        {
            generatedPlanets.Add(planetGeneration.GetRandomPlanet());
        }
        
    }
}
