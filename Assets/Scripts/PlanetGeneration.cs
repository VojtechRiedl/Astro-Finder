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
    private Planet gen;
    public bool IsGenerated { get => isGenerated; set => isGenerated = value; }

    void Start()
    {
        player.ActualPlanet = planetManager.planetPrefab.GetComponent<Planet>();
        //player.ActualPlanet = SpawnPlanet();

    }

    void Update()
    {
        /*if (!isGenerated)
        {
            player.ActualPlanet = SpawnPlanet();
        }*/
    }

    public void SpawnPlanet()
    {
        if (player.ActualPlanet != null)
        {
            player.ActualPlanet.DestroyPlanet();

        }
        if (planetManager.planetPrefab != null)
        {
            planetManager.destroyFirst();
        }
        var planet = gen;
        isGenerated = true;
        planet = planet.GeneratePlanet();
        player.gameObject.transform.position = new Vector3(planet.SpawnPoint.gameObject.transform.position.x, planet.SpawnPoint.gameObject.transform.position.y, player.gameObject.transform.position.z);
        player.ActualPlanet = planet;
    }

    public void setPlanet(Planet pl)
    {
        gen = pl;
    }

    
    
}
