using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class MovePaddle : MonoBehaviour
{
    
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -14, 0);
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3( (Input.GetAxisRaw("Horizontal"))*-30f, 0, 0)*Time.deltaTime;
        
        if (transform.position.x >=10)
        {
            transform.position = new Vector3(10,-14.1f,0);
        }
        if (transform.position.x <= -10)
        {
            transform.position = new Vector3(-10, -14.1f, 0);
            
        }
    }
}
