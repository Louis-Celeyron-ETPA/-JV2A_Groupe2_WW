using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Brandon;

public class InputTemporaire : MonoBehaviour
{

    public Voleur voleur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            voleur.descending = true;
        }
    }

    
}
