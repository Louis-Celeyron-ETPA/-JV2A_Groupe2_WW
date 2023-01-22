using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class PaddleBall : MonoBehaviour
    {

        public float speed;
        public Rigidbody rb;

        public Vector3 startPosition;

        private float x;
        private float y;

        // Start is called before the first frame update
        void Start()
        {
            Launch();
        }

        private void Launch()
        {
            if (Random.Range(0, 2) == 0)
            {
                x = -1;
            }
            else
            {
                x = 1;
            }

            if (Random.Range(0, 2) == 0)
            {
                y = -1;
            }
            else
            {
                y = 1;
            }

            rb.velocity = new Vector3(speed * x, speed * y);
        }

    }
}
