using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BallMomentum : MonoBehaviour
{
    Rigidbody rb;
    public int points=0;

    [SerializeField]
    GameObject textgameobject;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, -20, 0,ForceMode.VelocityChange);
        text = textgameobject.GetComponent<TextMeshProUGUI>();
    
    }
    [SerializeField]
    float speed = 10;
    int lives = 3;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
        if (transform.position.y < -17)
        {
            transform.position = new Vector3(0, -3.4f, 0);
            lives--;
        }
        text.text = "Lives:" + lives;
        if (lives == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        //fixes infinite wallbounce
        if (Math.Abs(rb.velocity.y) < 5)
        {
            rb.AddForce(0, -5, 0, ForceMode.Impulse);
        }
        void addpoint()
        {
            points++;
        }
    }
}
