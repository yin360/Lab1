using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float torque;
    [SerializeField] private float force;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(0,torque,0);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(0,-45,force,ForceMode.Impulse);
    }
}
