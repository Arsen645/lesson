using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int health = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    internal void ApplyDamage(int damage)
    {
        health -= damage;
        if (health < 0 )
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
