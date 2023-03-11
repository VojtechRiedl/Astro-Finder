using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxAttracter : MonoBehaviour
{
    public float gravity = -100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Attract(Transform body, Rigidbody rigidbody)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;

        Vector3 bodyUp = body.up;

        rigidbody.AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
        Debug.Log(targetRotation);
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);
    }
}
