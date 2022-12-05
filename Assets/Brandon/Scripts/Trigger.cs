using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{
    public class Trigger : MonoBehaviour
    {
        public int direction;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Voleur voleurTriggered = collision.GetComponent<Voleur>();
            if (voleurTriggered != null)
            {
                voleurTriggered.direction = direction;
            }

        }
    }
}

