using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;

    public GameObject SpawnPoint { get => spawnPoint; }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public Planet GeneratePlanet()
    {
        Instantiate(this, new Vector3(0, 100, 0), Quaternion.identity);
        return this;
    }
}
