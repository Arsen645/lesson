using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSControl : MonoBehaviour
{
    public GameObject knifeCloneTemplate;
    float speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // make Ed walk backwards with animation
            transform.position += speed * transform.right * Time.deltaTime * (-1);

        }
        if (Input.GetKey(KeyCode.D))
        {
            // make Ed walk backwards with animation
            transform.position += speed * transform.right * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDir.Normalize();
            transform.position += speed * fpsMovementDir * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDir.Normalize();
            transform.position -= speed * fpsMovementDir * Time.deltaTime;
        }
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);

        transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(knifeCloneTemplate, transform.position, transform.rotation);
            Ray bullet = new Ray(transform.position, transform.forward);
            RaycastHit info;
            if (Physics.Raycast(bullet, out info))
            {
                Health healthVictim = info.collider.GetComponent<Health>();
                if (healthVictim != null)
                {
                    healthVictim.ApplyDamage(20);
                }
            }


        }

        if (Input.GetKeyDown(KeyCode.R))//safe this but change the button
        {
            Instantiate(knifeCloneTemplate, transform.position, transform.rotation);
        }
    }
}
