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
    GameObject ball;
    
    

    TextMeshProUGUI TextComp;
    
    void Start()
    {
        TextComp = TextGameObject.GetComponent<TextMeshProUGUI>();
        
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);

        

    }

    // Update is called once per frame
    void Update()
    {
        TextComp.text = "Points:";
    }
    
}
