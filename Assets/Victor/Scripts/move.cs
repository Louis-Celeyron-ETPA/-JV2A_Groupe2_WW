using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Transform subject;
    public float speed = 10f;
    public float distanceRay = 10f;

    // Start is called before the first frame update
    void Start()
    {
        if (Physics.Raycast(subject.position, Vector3.down,1.1f)) 
        {

            speed = 0;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveRight()
    {
        subject.position += subject.right * speed;
        if (Physics.Raycast(subject.position, Vector3.down, distanceRay))
        {

            speed = 0;

        }
    }
    public void MoveLeft()
    {
        subject.position -= subject.right * speed;
        if (Physics.Raycast(subject.position, Vector3.down, distanceRay))
        {

            speed = 0;

        }
    }



}
