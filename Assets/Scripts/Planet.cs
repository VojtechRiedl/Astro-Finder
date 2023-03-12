using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planet : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private string planetName;
    [SerializeField]
    private planettype planetType;
    public enum planettype
    {
        green, toxic, magma, winter, iradiated, storm, earthquake
    }

    private float timeToDestruction;

    private bool readyToDestroy = false;
    public GameObject SpawnPoint { get => spawnPoint; }
    public float TimeToDestruction { get => timeToDestruction; }
    public bool ReadyToDestroy { get => readyToDestroy; }
    public planettype Type { get => planetType; }

    void Awake()
    {
        timeToDestruction = Random.Range(400f, 800);//Random.Range(480f, 900f); 
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
            SceneManager.LoadScene("EndScene");
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
        Destroy(gameObject.GetComponentInParent<Planet>());
    }

    public string GetPlanetName()
    {
        return planetName;
    }

    /*public string GetPlanetType()
    {
        string pltp = type.ToString();
        return pltp;
    }*/
}
