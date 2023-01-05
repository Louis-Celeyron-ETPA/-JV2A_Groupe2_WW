using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class PaddleBall : MonoBehaviour
    {

        public float speed;
        public Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            Launch();
        }

        private void Launch()
        {
            float x = Random.Range(0, 2) == 0 ? -1 : 1;
            float y = Random.Range(0, 2) == 0 ? -1 : 1;
            rb.velocity = new Vector3(speed * x, speed * y);
        }
    }
}
