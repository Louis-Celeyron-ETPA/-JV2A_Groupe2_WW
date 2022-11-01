using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
public class Paddle : MonoBehaviour
{
    public bool player;
    public bool player2;
    public float speed;
    public Rigidbody rb;

    private float mouvement;

        // Update is called once per frame
        void Update()
        {
            if (player)
            {
                mouvement = Input.GetAxisRaw("Vertical");
            }
            else
            {
                mouvement = Input.GetAxisRaw("Vertical2");
            }

            rb.velocity = new Vector3(rb.velocity.x, mouvement * speed);

        }

        /*
                if (player2)
                {
                    mouvement = Input.GetAxisRaw("Horizontal");
                }
                else
                {
                    mouvement = Input.GetAxisRaw("Horizontal2");
                }

                rb.velocity = new Vector3(rb.velocity.y, mouvement * speed);
        */

        }

}