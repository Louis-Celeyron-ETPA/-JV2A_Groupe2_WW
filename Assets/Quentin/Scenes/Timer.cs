using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    float tick;
    public float TimerInterval=5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        time = (int)Time.time;
        
    }
}
