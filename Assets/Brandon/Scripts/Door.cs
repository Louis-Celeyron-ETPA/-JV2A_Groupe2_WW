using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour

{
    public Transform doorTransform;
    public bool open = false;

    private Vector3 positionTarget = new Vector3(10f, 0f, 0f);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(open)
        {
            Debug.Log("je clic donc je m'ouvre");

        }
    }
}
