using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color =Color.yellow;
    }
}
