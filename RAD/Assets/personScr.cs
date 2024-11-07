using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personScr : MonoBehaviour
{
    int health = 100;
    int damage = 15;
    Rigidbody rb;
    internal void ExplosionAt(Vector3 position, float explosionRadius, float explosionStrength)
    {
        health -= damage;
        print("hhhhhhhhh " + health.ToString());
        rb.AddExplosionForce(explosionStrength/10, position, explosionRadius);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
