using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baptiste;

namespace Baptiste
{
    public class ReceiptBehavior : MonoBehaviour
    {
        public int behaviorType;
        public bool goingUp;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (behaviorType == 0)
            {
                transform.position -= Vector3.right * 0.05f;
                if (goingUp)
                {
                    transform.position += Vector3.up * 0.05f;
                    if (transform.position.y > 5.7f)
                    {
                        goingUp = false;
                    }
                }
                else
                {
                    transform.position -= Vector3.up * 0.05f;
                    if (transform.position.y < -3.7f)
                    {
                        goingUp = true;
                    }
                }
            }
            else if (behaviorType == 1)
            {
                transform.position -= Vector3.right * 0.05f;
            }
            else if (behaviorType == 2)
            {
                transform.position -= Vector3.right * 0.1f;
            }
            
        }
    }
}
