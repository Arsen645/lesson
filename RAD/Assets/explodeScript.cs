using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeScript : MonoBehaviour
{
    Rigidbody rb;
    float explosionRadius = 10;
    float explosionStrength = 1000;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(100 * transform.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimColliders = Physics.OverlapSphere(transform.position, explosionRadius);
            foreach (Collider col in allVictimColliders)
        {
            personScr personVictim = col.GetComponent<personScr>();
             if (personVictim != null)
            {
                personVictim.ExplosionAt(transform.position, explosionRadius, explosionStrength);
            }

            Rigidbody rigidbody = col.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(explosionStrength, transform.position, explosionRadius);
            }
        }
            Destroy(gameObject);
    }
}
