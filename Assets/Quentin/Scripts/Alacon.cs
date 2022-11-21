using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alacon : MonoBehaviour
{
    public float force = 100;
    public Rigidbody2D rgbd;
    public float size = 1;//Louis
    public LayerMask lm; //Louis
    private bool launched = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Louis debut 
        var collision = Physics2D.CircleCast(transform.position, size, Vector2.one,0,lm);
        if (collision)
        {
            if(!launched)
            {
               rgbd.AddForce(collision.normal* force);
                launched = true;
                
            }
            else
            if(launched == true)
            {
                launched = false;
            }
                
        }
        //fin louis
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 1, 0.5f);
        Gizmos.DrawSphere(transform.position, size);
    }
}
