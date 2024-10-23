using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EdsAnomationSkript : MonoBehaviour
{
    Animator EDSanimator;
    // Start is called before the first frame update
    float speed = 3;
    void Start()
    {
        EDSanimator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        EDSanimator.SetBool("backwardsRunning", false);

        if (Input.GetKey(KeyCode.S))
        {
            // make Ed walk backwards with animation
            EDSanimator.SetBool("backwardsRunning", true);
            transform.position += speed * transform.forward * Time.deltaTime*(-1);
        }
    }
}
