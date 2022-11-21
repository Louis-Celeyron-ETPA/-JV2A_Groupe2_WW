using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
public class Paddle : MonoBehaviour
{
    public bool player;
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

            rb.velocity = new Vector3(rb.velocity.x, mouvement * speed);
        }

        }

}