using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class BalloonMouvement : MonoBehaviour
    {
        public bool cursor;
        public float speed;
        public Rigidbody rb;

        private float mouvement;

        // Update is called once per frame
        void Update()
        {
            if (cursor)
            {
                mouvement = Input.GetAxisRaw("Vertical");
            }
            else

            {
                mouvement = Input.GetAxisRaw("Horizontal");
            }

            rb.velocity = new Vector3(rb.velocity.y, mouvement * speed);

        }



    }

}
