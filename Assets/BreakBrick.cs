using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BreakBrick : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject TextGameObject;
    [SerializeField]
    
    

    

    TextMeshProUGUI TextComp;
    
    void Start()
    {
        TextComp = TextGameObject.GetComponent<TextMeshProUGUI>();


        
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //GameObject ball = collision.gameObject;
        //BallMomentum addpoint = ball.GetComponent<BallMomentum>();
        
        
        Destroy(gameObject);

        

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
