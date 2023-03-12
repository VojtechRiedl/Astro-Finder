using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uprgrades : MonoBehaviour
{
    [SerializeField]
    private GameObject globalVariables;

    private Stats st;
    private Resources rs;
    private void Awake()
    {
        st = globalVariables.GetComponent<Stats>();
        rs = globalVariables.GetComponent<Resources>();
    }

    public void MaxHealth1()
    {
        if (rs.GetIron() >= 10)
        {
            st.AddMaxHealth(50);
            rs.AddIron(-10);
        }
        
    }
    public void MaxHealth2()
    {
        if (rs.GetIron() >= 10 && rs.GetCopper() >= 10)
        {
            st.AddMaxHealth(50);
            rs.AddIron(-10);
            rs.AddCopper(-10);
        }
    }
    public void MaxHealth3()
    {
        if (rs.GetCopper() >= 10 && rs.GetIgnium() >= 5 && rs.GetIridium() >= 5)
        {
            st.AddMaxHealth(100);
            rs.AddCopper(-10);
            rs.AddIgnium(-5);
            rs.AddIridium(-10);
        }
    }
    public void Speed1()
    {
        if (rs.GetIron() >= 10 && rs.GetSensium() >= 10) 
        {
            st.AddSpeed(10);
            rs.AddIron(-10);
            rs.AddSensium(-10);   
        }
    }
    public void Speed2()
    {
        if (rs.GetIridium() >= 10 && rs.GetUranium() >= 10)
        {
            st.AddSpeed(10);
            st.AddRadResist(-10);
            rs.AddIridium(-10);
            rs.AddUranium(-10);
        }
    }
    public void RadResist1()
    {
        if (rs.GetIron() >= 10 && rs.GetCopper() >= 10)
        {
            st.AddRadResist(50);
            rs.AddIron(-10);
            rs.AddCopper(-10);
        }
    }
    public void RadResist2()
    {

        if (rs.GetIridium() >= 5 && rs.GetCopper() >= 10)
        {
            st.AddRadResist(40);
            rs.AddIridium(-5);
            rs.AddCopper(-10);
        }
    }
    public void ColdResist1()
    {

        if (rs.GetIron() >= 10 && rs.GetIgnium() >= 15)
        {
            st.AddColdResist(50);
            rs.AddIron(-10);
            rs.AddIgnium(-15);
        }
    }
    public void ColdResist2()
    {

        if (rs.GetIridium() >= 5 && rs.GetIgnium() >= 20)
        {
            st.AddColdResist(40);
            rs.AddIridium(-5);
            rs.AddIgnium(-20);
        }
    }
    public void AcidResist1()
    {

        if (rs.GetCopper() >= 20)
        {
            st.AddAcidResist(50);
            rs.AddCopper(-20);
        }
    }
    public void AcidResist2()
    {

        if (rs.GetIridium() >= 5 && rs.GetCopper() >= 20)
        {
            st.AddAcidResist(40);
            rs.AddIridium(-5);
            rs.AddCopper(-20);
        }
    }

    public void MinigSpeed1()
    {

        if (rs.GetIron() >= 10 && rs.GetCopper() >= 10 && rs.GetIgnium() >= 10)
        {
            st.AddMiningSpeed(2);
            rs.AddIron(-10);
            rs.AddCopper(-10);
            rs.AddIgnium(-10);
        }
    }
    public void MinigSpeed2()
    {

        if (rs.GetIridium() >= 10 && rs.GetCopper() >= 20 && rs.GetIgnium() >= 15)
        {
            st.AddMiningSpeed(2);
            rs.AddIridium(-10);
            rs.AddCopper(-20);
            rs.AddIgnium(-15);
        }
    }
    public void MinigSpeed3()
    {
        if(rs.GetIridium() >= 25 && rs.GetSensium() >= 15 && rs.GetIgnium() >= 15)
        {
            st.AddMiningSpeed(2);
            rs.AddIridium(-25);
            rs.AddSensium(-15);
            rs.AddIgnium(-15);
        }
    }
    public void Damage1()
    {
        if (rs.GetIron() >= 10 && rs.GetSensium() >= 15)
        {
            st.AddDamage(5);
            rs.AddSensium(-15);
            rs.AddIron(-10);
        }
    }
    public void Damage2()
    {
        if (rs.GetIron() >= 20 && rs.GetIridium() >= 10 && rs.GetSensium() >= 10)
        {
            st.AddDamage(5);
            rs.AddIron(-20);
            rs.AddIridium(-10);
            rs.AddSensium(-10);
        }
    }
    public void Damage3()
    {
        if (rs.GetIron() >= 30 && rs.GetIridium() >= 20 && rs.GetSensium() >= 15)
        {
            st.AddDamage(5); 
            rs.AddIron(-30);
            rs.AddIridium(-20);
            rs.AddSensium(-15);
        }
    }


    public void FuelCappacity1()
    {
        if (rs.GetIron() >= 20)
        {
            st.AddFuelCapacity(10);
            rs.AddIron(-20);
        }
    }
    public void FuelCappacity2()
    {
        if (rs.GetIron() >= 25 && rs.GetCopper() >= 15)
        {
            st.AddFuelCapacity(10);
            rs.AddIron(-25);
            rs.AddCopper(-15);
        }
    }
    public void FuelCappacity3()
    {
        if (rs.GetIron() >= 35 && rs.GetIridium() >= 10)
        {
            st.AddFuelCapacity(10);
            rs.AddIron(-35);
            rs.AddIridium(-10);
        }
    }


    public void TelescopeRange1()
    {
        if (rs.GetIron() >= 10 && rs.GetSensium() >= 5)
        {
            st.AddTelescopeRange(1);
            rs.AddIron(-10);
            rs.AddSensium(-5);
        }
    }
    public void TelescopeRange2()
    {
        if (rs.GetIron() >= 15 && rs.GetSensium() >= 15 && rs.GetCopper() >= 10)
        {
            st.AddTelescopeRange(1);
            rs.AddIron(-30);
            rs.AddSensium(-25);
            rs.AddCopper(-10);
        }
    }
    public void TelescopeRange3()
    {
        if (rs.GetIron() >= 20 && rs.GetSensium() >= 25 && rs.GetCopper() >= 10 && rs.GetIridium() >= 25)
        {
            st.AddTelescopeRange(1);
            rs.AddIron(-30);
            rs.AddSensium(-25);
            rs.AddCopper(-10);
            rs.AddIridium(-25);
        }
    }
    public void TelescopeRange4()
    {
        if (rs.GetIron() >= 40 && rs.GetSensium() >= 35 && rs.GetCopper() >= 15 && rs.GetIridium() >= 40 && rs.GetUranium() >= 25)
        {
            st.AddTelescopeRange(1);
            rs.AddIron(-40);
            rs.AddSensium(-35);
            rs.AddCopper(-15);
            rs.AddIridium(-40);
            rs.AddUranium(-25);
        }
    }
    public void MaterialScanner()
    {
        if (rs.GetIron() >= 10 && rs.GetSensium() >= 20 && rs.GetCopper() >= 10)
        {
            st.SetMaterialScanner(true);
            rs.AddIron(-10);
            rs.AddSensium(-20);
            rs.AddCopper(-10);
        }
    }
    public void ThreatAnalyzer()
    {
        if (rs.GetIron() >= 10 && rs.GetSensium() >= 10 && rs.GetCopper() >= 10)
        {
            st.SetThreatAnalyzer(true);
            rs.AddIron(-10);
            rs.AddSensium(-10);
            rs.AddCopper(-10);

        }
    }
}
