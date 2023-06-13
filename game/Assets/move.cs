using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-1000 * Time.deltaTime, 0, 0);

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, 1000 * Time.deltaTime);
        }
    }
}