using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    private bool monte;
    // Start is called before the first frame update
    void Start()
    {
        monte = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(monte == true) {
            transform.position += Vector3.up * 0.1f;
            if (transform.position.y > 6)
            {
                monte = false;
            }
        }
        else
        {
            transform.position += Vector3.down * 0.1f;
            if (transform.position.y < 0)
            {
                monte = true;
            }
        }
    }
}
