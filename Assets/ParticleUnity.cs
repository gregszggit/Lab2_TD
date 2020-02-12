using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleUnity : MonoBehaviour
{
    public Vector3 initialVel;
    public Vector3 newPos;
    public Rigidbody rb;
    Vector3 updateForce;
    

    // Start is called before the first frame update
    void Start()
    {
        //set the initial position of a spawned particle
        transform.position = Vector3.zero;
        //set initial velocity of the spawned particle
        initialVel = 0.0f * Vector3.one;
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVel;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //create a force field
        newPos = transform.position;//get the particle postion
        updateForce = Vector3.one;
        //push the particle witht the force field
        rb.AddForce(updateForce);

    }
}
