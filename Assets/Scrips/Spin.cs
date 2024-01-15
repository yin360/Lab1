using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]private float spin;
    [SerializeField]private float force;
    private Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    
    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(force,force,0,ForceMode.Impulse);
    }
}
