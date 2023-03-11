using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;

    private float timeToDestruction;

    private bool readyToDestroy = false;
    public GameObject SpawnPoint { get => spawnPoint; }
    public float TimeToDestruction { get => timeToDestruction; }
    public bool ReadyToDestroy { get => readyToDestroy; }

    void Start()
    {
        timeToDestruction = Random.Range(20f, 30f);
    }

    void Update()
    {
        Debug.Log(timeToDestruction);
        if (timeToDestruction > 0)
        {
            timeToDestruction -= Time.deltaTime;
        }
        else
        {
            readyToDestroy = true;
        }
    }


    public Planet GeneratePlanet()
    {
        Instantiate(this, new Vector3(0, 100, 0), Quaternion.identity);
        return this;
    }

    public void DestroyPlanet()
    {
        Destroy(gameObject);
    }
}
