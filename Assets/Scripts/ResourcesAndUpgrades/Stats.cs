using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;
    [SerializeField]
    private float health;
    [SerializeField]
    private float speed;

    [SerializeField]
    private float damage;
    [SerializeField]
    private float miningSpeed;

    [SerializeField]
    private float radResist;
    [SerializeField]
    private float coldResist;
    [SerializeField]
    private float acidResist;

    [SerializeField]
    private float rocketFuel;
    [SerializeField]
    private float fuelCapacity;

    [SerializeField]
    private int telescopeRange;
    [SerializeField]
    private bool materialScanner;
    [SerializeField]
    private bool threatAnalyzer;

    public float GetMaxHealth()
    {
        return maxHealth;
    }

    public float GetHealth()
    {
        return health;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public float GetDamage()
    {
        return damage;
    }

    public float GetMiningSpeed()
    {
        return miningSpeed;
    }

    public float GetRadResist()
    {
        return radResist;
    }

    public float GetColdResist()
    {
        return coldResist;
    }

    public float GetAcidResist()
    {
        return acidResist;
    }

    public float GetRocketFuel()
    {
        return rocketFuel;
    }

    public float GetFuelCapacity()
    {
        return fuelCapacity;
    }

    public int GetTelescopeRange()
    {
        return telescopeRange;
    }

    public bool HasMaterialScanner()
    {
        return materialScanner;
    }

    public bool HasThreatAnalyzer()
    {
        return threatAnalyzer;
    }


    public void AddMaxHealth(float value)
    {
        maxHealth += value;
    }

    public void AddHealth(float value)
    {
        health += value;
    }

    public void AddSpeed(float value)
    {
        speed += value;
    }

    public void AddDamage(float value)
    {
        damage += value;
    }

    public void AddMiningSpeed(float value)
    {
        miningSpeed += value;
    }

    public void AddRadResist(float value)
    {
        radResist += value;
    }

    public void AddColdResist(float value)
    {
        coldResist += value;
    }

    public void AddAcidResist(float value)
    {
        acidResist += value;
    }

    public void AddRocketFuel(float value)
    {
        rocketFuel += value;
    }

    public void AddFuelCapacity(float value)
    {
        fuelCapacity += value;
    }

    public void AddTelescopeRange(int value)
    {
        telescopeRange += value;
    }

    public void SetMaterialScanner(bool value)
    {
        materialScanner = value;
    }

    public void SetThreatAnalyzer(bool value)
    {
        threatAnalyzer = value;
    }
}
