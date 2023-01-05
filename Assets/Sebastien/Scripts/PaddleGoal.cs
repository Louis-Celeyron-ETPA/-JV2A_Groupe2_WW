using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class PaddleGoal : MonoBehaviour
    {
        public bool score;
        Rigidbody myRigidbody;

        private void Start()
        {
            myRigidbody = GetComponent<Rigidbody>();
        }

        void OnTriggerEnter(Collider triggerCollider)
        {
            if (triggerCollider.tag == "Ball")
            {
                Destroy(triggerCollider.gameObject);
            }
        }
    }

}
