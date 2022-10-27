using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class LampMove : MonoBehaviour
    {
        public Transform lamp;
        public TEMPOTOUCHES2 difficulty;
        public EndScene end;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (end.gameEnd == true)
            {
                return;
            }
            lamp.position += Vector3.forward * -0.4f * difficulty.difficulty;
        }

        public void FakeLampMove() 
        {
            if (end.gameEnd == true)
            {
                return;
            }
            transform.position += Vector3.forward * -0.4f * difficulty.difficulty;
        }
    }
}