using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private Transform rayHit;
    [SerializeField]
    private Transform rayOrigin;
    [SerializeField]
    private float distance;
    [SerializeField]
    private float reductionSpeed;
    [SerializeField]
    private float minScale;
    private GameObject Res;
    private float currentCooldown;
    private float cooldown = 1;

    // Start is called before the first frame update
    void Start()
    {
        distance = Distance();
        Debug.Log(distance);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCooldown > 0) {
            currentCooldown -= Time.deltaTime;
        }
        if (Input.GetMouseButtonDown(0) && currentCooldown <= 0) {
            //Physics.Raycast(rayOrigin.position,  -rayOrigin.forward, 55);
            //Debug.DrawRay(rayOrigin.position,  -rayOrigin.forward * 55, Color.red);
            Ray ray = new Ray(rayOrigin.position, -rayOrigin.forward * 55);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 55) && raycastHit.transform.CompareTag("res")) {
                currentCooldown = cooldown;
                Res = raycastHit.transform.gameObject;
                //raycast -> surky
                if (raycastHit.transform.localScale.x > minScale) {
                    raycastHit.transform.localScale -= new Vector3(reductionSpeed, reductionSpeed, reductionSpeed);
                }
                else
                {
                  //  Res.GetComponent<Ore>().GetMined();
                    Destroy(Res);
                }

            }
        }

    }

    float Distance()
    {
        return Vector3.Distance(rayOrigin.position,rayHit.position);

    }
}
