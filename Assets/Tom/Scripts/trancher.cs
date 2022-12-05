using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trancher : MonoBehaviour
{
    public Transform Slide;
    float speed = 2f;
    float height = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            Vector3 pos = Slide.position;

            float newY = Mathf.Sin(Time.time * speed);

            newY = newY * height;

            Slide.position = new Vector3(pos.x, newY, pos.z);
        }
    }
}

