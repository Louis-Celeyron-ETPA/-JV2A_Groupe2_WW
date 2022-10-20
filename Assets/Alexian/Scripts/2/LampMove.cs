using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class LampMove : MonoBehaviour
    {
        public Transform lamp;
        public TEMPOTOUCHES2 difficulty;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            lamp.position += Vector3.forward * -0.2f * difficulty.difficulty;
        }

        public void FakeLampMove() 
        {
            transform.position += Vector3.forward * -0.2f * difficulty.difficulty;
        }
    }
}