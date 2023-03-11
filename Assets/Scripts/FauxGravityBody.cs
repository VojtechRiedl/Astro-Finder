using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    public FauxAttracter attractor;
    private Transform myTransform;
    private Rigidbody rb;
    [SerializeField]
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = false;
        myTransform = transform;
        attractor = player.ActualPlanet.GetComponentInChildren<FauxAttracter>();
        Debug.Log(player.ActualPlanet);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(attractor);
        attractor.Attract(myTransform, rb);
    }
}
