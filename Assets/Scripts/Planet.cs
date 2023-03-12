using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private string planetName;
    [SerializeField] private string planetType; // tak co už

    private float timeToDestruction;

    private bool readyToDestroy = false;
    public GameObject SpawnPoint { get => spawnPoint; }
    public float TimeToDestruction { get => timeToDestruction; }
    public bool ReadyToDestroy { get => readyToDestroy; }
    

    void Awake()
    {
        timeToDestruction = Random.Range(40f, 52f);//Random.Range(480f, 900f); 
    }
    
    void Update()
    {
        if (timeToDestruction > 0)
        {
            timeToDestruction -= Time.deltaTime;
        }
        else
        {
            
            //Debug.Log("Ready to destroy 23");
            readyToDestroy = true;
            DestroyPlanet();
        }
    }

    public Planet GeneratePlanet()
    {
        Instantiate(this, new Vector3(0, 100, 0), Quaternion.identity);
        enabled = true;
        return this;
    }

    public void DestroyPlanet()
    {
        Debug.Log("Dead");
        DestroyImmediate(gameObject,true);
    }

    public string GetPlanetName()
    {
        return planetName;
    }

    public string GetPlanetType()
    {
        return planetType;
    }
}
