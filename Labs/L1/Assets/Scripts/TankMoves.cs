using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMoves : MonoBehaviour
{

    private Rigidbody rb;

    private float speed;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("s"))
        {
            rb.transform.Translate(0, 0, speed - Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            rb.transform.Translate(0, 0, speed + Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.transform.Rotate(0, speed + Time.deltaTime * 25, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.transform.Rotate(0, speed - Time.deltaTime * 25, 0);
        }
    }
}
