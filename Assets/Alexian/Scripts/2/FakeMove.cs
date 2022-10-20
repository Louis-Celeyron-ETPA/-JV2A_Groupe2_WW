using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class FakeMove : MonoBehaviour
    {
        public LampMove lamp;
        // Start is called before the first frame update
        void Start()
        {
            

            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void lampCreate()
        {
            var justSpawnedLamp = Instantiate(lamp, new Vector3(16.7f, 11.1f, 750f), Quaternion.Euler(0, 0, 0));
            justSpawnedLamp.FakeLampMove();
        }
    }
}