using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;

    public GameObject SpawnPoint { get => spawnPoint; }

    void Start()
    {
        Debug.Log(spawnPoint.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GeneratePlanet()
    {
        Instantiate(this, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
