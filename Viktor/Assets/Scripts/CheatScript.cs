using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatScript : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
        }
    }
}
