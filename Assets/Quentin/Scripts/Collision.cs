using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
    
{
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( gameOver == true)
        {
            Debug.Log("Yo");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        gameOver = true;
        Destroy(this);
    }
    
}
