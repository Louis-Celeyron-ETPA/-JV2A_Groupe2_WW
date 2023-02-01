using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Brandon
{
    public class Door : MonoBehaviour

    {
        public Transform doorTransform;
        public bool open = false;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (open)
            {
                Debug.Log("je clic donc je m'ouvre");
                doorTransform.rotation = Quaternion.Euler(0, -50, 0);
            }
        }
    }
}
