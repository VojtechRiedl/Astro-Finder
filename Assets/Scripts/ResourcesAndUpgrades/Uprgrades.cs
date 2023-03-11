using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uprgrades : MonoBehaviour
{
    [SerializeField]
    private GameObject globalVariables;

    private Stats stats;
    private Resources resources;
    private void Awake()
    {
        stats = globalVariables.GetComponent<Stats>();
        resources = globalVariables.GetComponent<Resources>();
    }

    public void MaxHealth1()
    {
        if (resources.GetIron() >= 10)
        {
            stats.AddMaxHealth(50);
            resources.AddIron(-10);
        }
        
    }
    public void MaxHealth2()
    {
        if (resources.GetIron() >= 10 && resources.GetCopper() >= 10)
            stats.AddMaxHealth(50);
    }
    public void MaxHealth3()
    {
        stats.AddMaxHealth(100);
    }
    public void Speed1()
    {
        stats.AddSpeed(10);
    }
    public void Speed2()
    {
        stats.AddSpeed(10);
    }
    public void RadResist1()
    {
        stats.AddRadResist(50);
    }
    public void RadResist2()
    {
        stats.AddRadResist(40);
    }
    public void ColdResist1()
    {
        stats.AddColdResist(50);
    }
    public void ColdResist2()
    {
        stats.AddColdResist(40);
    }
    public void AcidResist1()
    {
        stats.AddAcidResist(50);
    }
    public void AcidResist2()
    {
        stats.AddAcidResist(40);
    }

    public void MinigSpeed1()
    {
        stats.AddMiningSpeed(2);
    }
    public void MinigSpeed2()
    {
        stats.AddMiningSpeed(2);
    }
    public void MinigSpeed3()
    {
        stats.AddMiningSpeed(2);
    }
    public void Damage1()
    {
        stats.AddDamage(5);
    }
    public void Damage2()
    {
        stats.AddDamage(5);
    }
    public void Damage3()
    {
        stats.AddDamage(5);
    }


    public void FuelCappacity1()
    {
        stats.AddFuelCapacity(10);
    }
    public void FuelCappacity2()
    {
        stats.AddFuelCapacity(10);
    }
    public void FuelCappacity3()
    {
        stats.AddFuelCapacity(10);
    }


    public void TelescopeRange()
    {
        stats.AddTelescopeRange(1);
    }
    public void MaterialScanner()
    {
        stats.SetMaterialScanner(true);
    }
    public void ThreatAnalyzer()
    {
        stats.SetThreatAnalyzer(true);
    }


}
