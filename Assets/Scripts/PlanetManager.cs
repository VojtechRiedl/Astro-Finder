using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{

    HashSet<Planet> generatedPlanets = new HashSet<Planet>();

    [SerializeField]
    List<GameObject> planets = new List<GameObject>();
    [SerializeField]
    PlanetGeneration PlanetGeneration;

    void Awake()
    {
        GeneratePlanet();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
        HashSet<Planet> excludedObjects = new HashSet<Planet>();

        foreach (var planet in generatedPlanets)
        {
            //planet.UpdatePlanet(); 
            /*Debug.Log(planet.ReadyToDestroy);
            if (planet.ReadyToDestroy)
            {
                Debug.Log(planet.name);
                GeneratePlanet();
                //planet.DestroyPlanet();
                planet.gameObject.SetActive(false);
                excludedObjects.Add(planet);
            }*/

        }
        //Remove all elements in the second set from the first set.
        generatedPlanets.ExceptWith(excludedObjects);
    }

    public void GeneratePlanet()
    {
        for (int i = 0; i < 3; i++)
        {
            var planet = GetRandomPlanet();
            
            generatedPlanets.Add(planet);
        }
        
    }
    public Planet GetRandomPlanet()
    {
        return planets[UnityEngine.Random.Range(0, planets.Count)]
                .GetComponent<Planet>();
    }
    public Planet spawnRandomPlanet()
    {
        return generatedPlanets.ElementAt(UnityEngine.Random.Range(0, generatedPlanets.Count));
    }
    public void PlanetDestroyed(Planet p)
    {
        generatedPlanets.Remove(p);
        PlanetGeneration.IsGenerated = false;


    }

}
