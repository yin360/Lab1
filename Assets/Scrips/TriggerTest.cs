using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color=Color.blue;
    }
}
