using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trancher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        maxFallDistance = 0,394;

        if (transform.position.y <= maxFallDistance)
        {
            Debug.Log("Out of bounds!");


        }
    }
}
