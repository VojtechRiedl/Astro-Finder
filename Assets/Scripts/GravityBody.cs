using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{

    GravityAttractor planet;
    Rigidbody rigidbody;

    void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.useGravity = false;
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }


    public void getPlanet()
    {
        this.planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
    }
    void FixedUpdate()
    {
        if(planet == null)
        {
            planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();

        }
        planet.Attract(rigidbody);
    }
}