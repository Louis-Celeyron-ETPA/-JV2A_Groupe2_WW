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
            doorTransform.rotation = Quaternion.Euler(0, -60, 0);
            doorTransform.transform.position.Set(10.301622748f, 0.28945148f, 1.6208806f);
        }
    }
}
