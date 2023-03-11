using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{

    GravityAttractor planet;
    Rigidbody rigidbody;

    void Start()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.useGravity = false;
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        planet.Attract(rigidbody);
    }
}