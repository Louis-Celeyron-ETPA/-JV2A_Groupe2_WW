using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looping : MonoBehaviour
{
    public transform Slide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Slide.position += Vector3.up * Time.deltaTime;
    }
}