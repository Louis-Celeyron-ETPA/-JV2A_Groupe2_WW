using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementBlue : MonoBehaviour
{
    public Transform myTransform;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetKey(KeyCode.D))
            {
                if (Input.GetAxis("Vertical") == 0)
                {
                    myTransform.position = myTransform.position + Vector3.left * speed;
                    transform.Translate(Vector3.left * 0 * Time.deltaTime);
                    Debug.Log("LEFT!");
                }
            }

            {
                if (Input.GetKey(KeyCode.Z))
                {
                    if (Input.GetAxis("Horizontal") == 0)
                    {
                        myTransform.position = myTransform.position + Vector3.down * speed;
                        transform.Translate(Vector3.down * 0 * Time.deltaTime);
                        Debug.Log("DOWN!");
                    }
                }
            }

        }
    }
}