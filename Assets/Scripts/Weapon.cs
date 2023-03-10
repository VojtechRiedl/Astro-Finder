using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Transform rayHit;
    private Transform rayOrigin;
    private float distance;
    private float reductionSpeed;
    private float minScale;
    private GameObject Res;

    // Start is called before the first frame update
    void Start()
    {
        distance = Distance();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(rayOrigin.position, rayHit.position, distance);
        
        Debug.DrawRay(rayOrigin.position, Vector3.forward * distance, Color.red);

        Ray ray = new Ray(rayOrigin.position, Vector3.forward);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, distance) && raycastHit.transform.tag == "res")
        {
            Res = raycastHit.transform.gameObject;
            Debug.Log(raycastHit.transform.localScale.x);
            if (raycastHit.transform.localScale.x >= minScale)
            {
                raycastHit.transform.localScale -= new Vector3(reductionSpeed, reductionSpeed, reductionSpeed);
            }
            else
            {
                
                Destroy(Res);
            }

        }
        
    }

    public float Distance()
    {
        return Vector3.Distance(rayHit.position, rayOrigin.position);

    }
}
