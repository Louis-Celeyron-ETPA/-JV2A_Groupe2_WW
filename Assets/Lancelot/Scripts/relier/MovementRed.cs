using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// vieux code avant input manager pour bouger les carrés rouges.
public class MovementRed : MonoBehaviour
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
                    myTransform.position = myTransform.position + Vector3.right * speed;
                    transform.Translate(Vector3.right * 0 * Time.deltaTime);
                    Debug.Log("RIGHT!");
                }
            }

            {
                if (Input.GetKey(KeyCode.Z))
                {
                    if (Input.GetAxis("Horizontal") == 0)
                    {
                        myTransform.position = myTransform.position + Vector3.up * speed;
                        transform.Translate(Vector3.up * 0 * Time.deltaTime);
                        Debug.Log("UP!");
                    }
                }
            }

        }
    }
}