using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class FakeMove : MonoBehaviour
    {
        public LampMove lamp;
        public EndScene end;
        public Timing timing;

        void Start()
        {

        }

        void Update()
        {
            
        }

        public void lampCreate()
        {
            if(end.gameEnd == true)
            {
                return;
            }
            var justSpawnedLamp = Instantiate(lamp, new Vector3(16.7f, 11.1f, 415f), Quaternion.Euler(0, 0, 0));
            justSpawnedLamp.end = end;
            justSpawnedLamp.timing = timing;
            justSpawnedLamp.FakeLampMove();
        }
    }
}