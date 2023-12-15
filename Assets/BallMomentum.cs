using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BallMomentum : MonoBehaviour
{
    Rigidbody rb;
    public int points=0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, -20, 0,ForceMode.VelocityChange);
    }
    [SerializeField]
    float speed = 10;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
        if (transform.position.y < -17)
        {
            transform.position = new Vector3(0, -3.4f, 0);
        }
        if (Math.Abs(rb.velocity.y) < 5)
        {
            rb.AddForce(0, -5, 0, ForceMode.Impulse);
        }
    }
}
